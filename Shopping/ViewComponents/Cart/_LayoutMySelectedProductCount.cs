using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Cart
{
	public class _LayoutMySelectedProductCount:ViewComponent
	{
		ICartService _cartService;
		UserManager<AppUser> _userManager;

		public _LayoutMySelectedProductCount(ICartService cartService, UserManager<AppUser> userManager)
		{
			_cartService = cartService;
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var UserId = await _userManager.FindByNameAsync(User.Identity.Name);

			var List=_cartService.GetListByFilter(UserId.Id);
			return View(List);
		}
	}
}
