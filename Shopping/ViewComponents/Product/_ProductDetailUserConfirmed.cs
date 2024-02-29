
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Product
{
	public class _ProductDetailUserConfirmed:ViewComponent
	{
		UserManager<AppUser> _userManager;
		Context _context;

		public _ProductDetailUserConfirmed(UserManager<AppUser> userManager, Context context)
		{
			_userManager = userManager;
			_context = context;
		}
		public IViewComponentResult Invoke(int id)
		{
			var value = _context.Users.FirstOrDefault(x => x.Id == id);
			return View(value);
		}
	}
}
