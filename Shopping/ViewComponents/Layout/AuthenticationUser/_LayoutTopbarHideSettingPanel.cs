using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Layout.AuthenticationUser
{

    
    public class _LayoutTopbarHideSettingPanel:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _LayoutTopbarHideSettingPanel(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(value);
        }
    }
}
