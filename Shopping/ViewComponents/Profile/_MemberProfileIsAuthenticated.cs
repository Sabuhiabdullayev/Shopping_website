using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Profile
{
    public class _MemberProfileIsAuthenticated:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _MemberProfileIsAuthenticated(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.IsAuthenticatedId = user.Id==id;
            return View();
        }
    }
}
