using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Contact
{
    public class _MessageMemberNavbarDescription:ViewComponent
    {
    
        UserManager<AppUser> _userManager;

        Context _context;

        public _MessageMemberNavbarDescription(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            var valueList = _context.Users.FirstOrDefault(x=>x.Id==id);
      
            return View(valueList);
        }
    }
}
