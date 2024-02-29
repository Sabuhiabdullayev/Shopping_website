using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Shop
{
    public class _ShopMemberIsAuthenticated:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _ShopMemberIsAuthenticated(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.IsAuthenticatedId = user.Id == id;
            return View();
        }
    }
}
