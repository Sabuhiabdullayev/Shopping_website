using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Notification
{
	public class _MemberNotificationCount:ViewComponent
	{
		UserManager<AppUser> _userManager;
		INotificationService _notificationService;

		public _MemberNotificationCount(UserManager<AppUser> userManager, INotificationService notificationService)
		{
			_userManager = userManager;
			_notificationService = notificationService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var GetList = _notificationService.TGetFilterListNotification(user.Id).Where(x=>x.NotificationStatus==false).ToList();
			return View(GetList);
		}
	}
}
