using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Layout.LayoutUserList
{
	public class _LayoutUserListSlider:ViewComponent
	{
		UserManager<AppUser> _userManager;
		Context _context;

		public _LayoutUserListSlider(UserManager<AppUser> userManager, Context context)
		{
			_userManager = userManager;
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var List = _userManager.Users.Where(x=>x.MemberStatus=="Active").ToList();
			return View(List);
		}
	}
}
