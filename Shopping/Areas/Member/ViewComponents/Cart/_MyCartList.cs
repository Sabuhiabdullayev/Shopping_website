using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.Cart
{
    public class _MyCartList:ViewComponent
    {
        ICartService _cartService;
        UserManager<AppUser> _userManager;

		public _MyCartList(ICartService cartService, UserManager<AppUser> userManager)
		{
			_cartService = cartService;
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var UserId = await _userManager.FindByNameAsync(User.Identity.Name);

            var List = _cartService.TGetIncludeList().Where(x=>x.AppUserId==UserId.Id).ToList();
            return View(List);
        }
    }
}

