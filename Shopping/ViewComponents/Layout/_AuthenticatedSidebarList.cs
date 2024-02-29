using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Layout
{
	public class _AuthenticatedSidebarList:ViewComponent
	{
		UserManager<AppUser> _userManager;

		public _AuthenticatedSidebarList(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task <IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.UserName = user.UserName;
			ViewBag.ShopName = user.ShopName;
			ViewBag.ShopStatus = user.ShopStatus;
			return View();
		}
	}
}
