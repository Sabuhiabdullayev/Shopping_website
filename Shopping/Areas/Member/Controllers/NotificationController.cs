using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Shopping.Areas.Member.Controllers
{
	[Area("Member")]
	
	public class NotificationController : Controller
	{
	private readonly UserManager<AppUser> _userManager;
	private readonly INotificationService _notificationService;
		private readonly Context _context;

		public NotificationController(UserManager<AppUser> userManager, INotificationService notificationService, Context context)
		{
			_userManager = userManager;
			_notificationService = notificationService;
			_context = context;
		}
		
		public async Task<IActionResult> Content(int? id)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.id=id;
			
			var value = _notificationService.TGetById(id);
            if (id == null)
            {
				return View();
            }
			if(value != null && user.Id == value.MemberId)
            {
				return View(value);

            }
            else
            {
				return NotFound();
            }
		}
		[HttpPost]
		public IActionResult NotificationAloneDelete(int id)
        {
			var getBiId = _notificationService.TGetById(id);
			_notificationService.TDel(getBiId);
			return Json(getBiId);
        }
		[HttpPost]
		public IActionResult NotificationStatusFalse(int id)
		{
			var value = _notificationService.TGetById(id);
			value.NotificationStatus = true;
			_notificationService.TUpdate(value);
			return RedirectToAction("Content", "Notification",new {id=id});
		}

		[HttpPost]
		public async Task<IActionResult> DetailLikeAdd(Notification p)
        {
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			p.AppUserId = user.Id;
			p.Comment = false;
			p.Img = "";
			p.NotificationStatus = false;
			p.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
			p.Like = true;
			p.Title = "Elanınızı Bəyəndi";
			p.Content= "Elanınızı Bəyəndi";
			_notificationService.TAdd(p);
			var json = JsonConvert.SerializeObject(p);
			return Json(json);
        }
		[HttpPost]
		public async Task<IActionResult> AllDelete(int count)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			IEnumerable<Notification> notification = _context.Notifications.Take(count).Where(x => x.AppUserId == user.Id).ToList();
			_context.Notifications.RemoveRange(notification);
			_context.SaveChanges();
			return RedirectToAction("Content", "Notification", new { area = "Member" });
		}
		[HttpPost]
		public async Task<IActionResult> DetailCommentAdd(Notification p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			p.AppUserId = user.Id;
			p.Comment = true;
			p.Img = "";
			p.NotificationStatus = false;
			p.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
			p.Like = false;
			p.Title = "Elanınıza Rəy Bildirilib";
			_notificationService.TAdd(p);
			var json = JsonConvert.SerializeObject(p);
			return Json(json);
		}
		
	}
}
