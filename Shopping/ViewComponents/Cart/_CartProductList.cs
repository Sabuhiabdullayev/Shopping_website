using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Cart
{
    public class _CartProductList:ViewComponent
    {
		ICartService _cartService;
		UserManager<AppUser> _userManager;
		Context _context;

        public _CartProductList(ICartService cartService, UserManager<AppUser> userManager, Context context)
        {
            _cartService = cartService;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
		{
            var UserId = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.CartProductId = id;
			var List = _cartService.TGetList().Where(x=>x.ProductId==id && x.AppUserId==UserId.Id).ToList();
            
            return View(List);	
        }
	}
}
