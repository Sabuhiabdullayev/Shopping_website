using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.User
{
    public class _MembersList:ViewComponent
    {
        UserManager<AppUser> _userManager;
        Context _context;

        public _MembersList(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Users.Where(x=>x.MemberStatus== "Active").ToList();
            return View(value);
        }
    }
}
