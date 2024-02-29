using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models.MemberProfile;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;
        Context _context;

        public UserController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Members()
        {
           
            return View();
        }
        [Route("{controller=Home}/{action=AllProductPage}/{userName?}")]
        public IActionResult Profile(string? userName)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == userName);

            if (userName != null && user != null && user.MemberStatus == "Active")
            {
               ViewBag.UserId=user?.Id;
                return View(user);
            }
            return NotFound();
        }

        [HttpGet]
        public PartialViewResult ProfileDescriptionUpdate()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> ProfileDescriptionUpdate(MemberProfileUpdateViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.MemberDescription = model.MemberDescription;
            user.MemberSpecialWebSite = model.MemberSpecialWebSite;
            user.MemberFacebookWebSite = model.MemberFacebookWebSite;
            user.MemberInstagramWebSite = model.MemberInstagramWebSite;
            user.MemberTiktokWebSite = model.MemberTiktokWebSite;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Profile", "User", new { user.UserName });
            }
            return View(model);
        }
   
    }
}
