using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.Shop;
using Shopping.Areas.Admin.Models.User;
using X.PagedList;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ShopController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ShopController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ShopList(int Page = 1)
        {
            var users = _userManager.Users.Where(x=>x.ShopName!= null).ToList().ToPagedList(Page, 20);
            return View(users);
        }
        public IActionResult ConfirmedList()
        {
            return View();
        }

        public IActionResult ShopStatusGive(int? id)
        {
            if (id != null)
            {
                var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
                return View(user);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> ShopStatusGiveUpdate(ShopConfirmedGiveViewModel model)
        {
            Context c = new Context();
            var user = _userManager.Users.FirstOrDefault(x => x.Id == model.ShopId);
            user.ShopConfirmed = model.ShopConfirmed;
            user.Id = model.ShopId;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ConfirmedList", "Shop", new { area = "Admin" });

            }
            else
            {
                return View(model);
            }

        }
        [HttpPost]
        public async Task<IActionResult> ShopStatusActive(MemberActiveStatusViewModel model)
        {
            var userActive = _userManager.Users.FirstOrDefault(x => x.Id == model.UserId);
            userActive.Id = model.UserId;
            userActive.ShopStatus = model.UserStatus;
            var result = await _userManager.UpdateAsync(userActive);
            if (result.Succeeded)
            {
                return RedirectToAction("ShopList", "Shop", new { area = "Admin" });
            }
            return View();
        }
    }
}

 

