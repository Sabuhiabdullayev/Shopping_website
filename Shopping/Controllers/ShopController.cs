using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models.MemberProfile;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class ShopController : Controller
    {
        UserManager<AppUser> _userManager;
        Context _context;
        public ShopController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Shops()
        {
            return View();
        }
        [Route("{controller=Home}/{action=AllProductPage}/{shopName?}")]
        public IActionResult InShop(string? shopName)
        {
            var value = _userManager.Users.FirstOrDefault(x => x.ShopName == shopName);

            if (shopName != null && value != null)
            {

                ViewBag.UserId=value.Id;
                return View(value);
            }
            return NotFound();
        }

        [HttpGet]
        public PartialViewResult ShopDescriptionUpdate()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> ShopDescriptionUpdate(MemberProfileUpdateViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.ShopDescription = model.MemberDescription;
            user.ShopMemberSpecialWebSite = model.MemberSpecialWebSite;
            user.ShopMemberFacebookWebSite = model.MemberFacebookWebSite;
            user.ShopMemberInstagramWebSite = model.MemberInstagramWebSite;
            user.ShopMemberTiktokWebSite = model.MemberTiktokWebSite;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("InShop", "Shop", new { user.ShopName });
            }
            return View(model);
        }
    }
}
