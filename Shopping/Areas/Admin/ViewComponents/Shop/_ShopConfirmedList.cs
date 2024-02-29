using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Shop
{
    public class _ShopConfirmedList:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _ShopConfirmedList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            var userList = _userManager.Users.Where(x => x.ShopStatus == "Təsdiqləndi").ToList();
            return View(userList);
        }
    }
}
