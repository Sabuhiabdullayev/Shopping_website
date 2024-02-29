using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.Notification;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator,Writer")]
    public class NotificationController : Controller
    {
        INotificationService _notificationService;
        UserManager<AppUser> _userManager;

        public NotificationController(INotificationService notificationService, UserManager<AppUser> userManager)
        {
            _notificationService = notificationService;
            _userManager = userManager;
        }
        public IActionResult NotificationAllList()
		{
            var AllList = _notificationService.TGetList();
            return View(AllList);
		}

        [HttpGet]
        public IActionResult NotificationSend()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NotificationSend(NotificationAddViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Notification p = new Notification();
            if (model.Img != null)
            {
                var Extension = Path.GetExtension(model.Img.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/NotificationImg/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Img.CopyTo(Stream);
                p.Img = newImageName;
            }
            else
            {
                p.Img ="null";
            }
                p.Title = model.Title;
                p.Content = model.Content;
            p.NotificationStatus = false;
                p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			if (model.MemberId != null)
			{
                p.MemberId = model.MemberId;

			}
			else
			{
                p.MemberId = 0;

            }
            p.AppUserId = user.Id;

            _notificationService.TAdd(p);
            return RedirectToAction("NotificationAllList", "Notification", new { area = "Admin" });
        }
        public IActionResult Delete(int id)
        {
            var getId = _notificationService.TGetById(id);
            _notificationService.TDel(getId);
            return RedirectToAction("NotificationAllList", "Notification", new { id =id });
        }
        public IActionResult Update(int id)
        {
            var getId = _notificationService.TGetById(id);
            return View(getId);
        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateNotification(NotificationAddViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Notification p = new Notification();
            if (model.Img != null)
            {
                var Extension = Path.GetExtension(model.Img.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/NotificationImg/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Img.CopyTo(Stream);
                p.Img = newImageName;
            }
            else
            {
                p.Img = p.Img;
            }
            p.Title = model.Title;
            p.Content = model.Content;
            p.NotificationStatus = p.NotificationStatus;
            p.Date = p.Date;
            if (model.MemberId != null)
            {
                p.MemberId = model.MemberId;

            }
            else
            {
                p.MemberId = 0;

            }
            p.AppUserId = user.Id;

            _notificationService.TUpdate(p);
            return RedirectToAction("NotificationAllList", "Notification", new { area = "Admin" });
        }

    }
}
