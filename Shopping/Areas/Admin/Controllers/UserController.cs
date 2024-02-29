using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.User;
using X.PagedList;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;
        Context _context;
        public UserController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context=context;
        }

        public IActionResult UserList(int Page=1)
        {
          
            return View(_context.Users.ToList().ToPagedList(Page, 20));
        }
        public IActionResult ConfirmedList()
        {
            return View();
        }

        public IActionResult UserStatusGive(int? id)
        {
            if (id != null)
            {
                var userbyid = _userManager.Users.FirstOrDefault(x => x.Id == id);
                return View(userbyid);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpPost]
        public async Task<IActionResult> UserStatusGiveUpdate(UserConfirmedGiveViewModel model)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == model.UserId);
            user.Id = model.UserId;
            user.confirmed = model.UserConfirmedStatus;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ConfirmedList", "User", new { area = "Admin" });

            }
            else
            {
                return View();
            }

        }
     
        public async Task<IActionResult> UserDelete(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("UserList", "User", new { area = "Admin" });

            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> UserStatusActive(MemberActiveStatusViewModel model)
        {
            var userActive = _userManager.Users.FirstOrDefault(x=>x.Id == model.UserId);
            userActive.Id = model.UserId;
            userActive.MemberStatus = model.UserStatus;
            var result = await _userManager.UpdateAsync(userActive);
            if (result.Succeeded)
            {
                return RedirectToAction("UserList", "User", new {area="Admin" });
            }
            return View();
        }
    }
}
