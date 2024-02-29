using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Shopping.Areas.Member.ViewComponents.Notification
{
	public class _MyNotificationContentSendUser:ViewComponent
	{
		UserManager<AppUser> _userManager;

		public _MyNotificationContentSendUser(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		public IViewComponentResult Invoke(int id)
		{
			var user = _userManager.Users.FirstOrDefault(x=>x.Id==id);
			return View(user);
		}
	}
}
