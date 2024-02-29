using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Shop
{
    public class _AllShops:ViewComponent
    {
        UserManager<AppUser> _userManager;
        Context _context;

        public _AllShops(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _userManager.Users.Where(x => x.ShopStatus == "Active" && x.MemberStatus== "Active").ToList();
            return View(value);
        }
    }
}
