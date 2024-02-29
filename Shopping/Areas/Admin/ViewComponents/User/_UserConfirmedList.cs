using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.User
{
    public class _UserConfirmedList:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _UserConfirmedList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            var userList = _userManager.Users.ToList();
            return View(userList);
        }
    }
}
