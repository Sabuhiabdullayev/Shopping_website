using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.LayoutAdmin
{
    public class _HeaderPartial:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _HeaderPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Values = await _userManager.FindByNameAsync(User?.Identity?.Name);
            ViewBag.confirmed = Values.confirmed.ToString();
            return View(Values);
        }
    }
}
