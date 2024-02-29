using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Layout.AuthenticationUser
{
    public class _LayoutAuthenticationTapBarNameImg_COM:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _LayoutAuthenticationTapBarNameImg_COM(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var confirm = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(confirm);
        }
    }
}
