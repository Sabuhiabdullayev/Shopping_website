using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.Roles;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminRolesController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminRolesController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult RoleList()
        {
            var value = _roleManager.Roles.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddRole()
		{
            return View();
		}

        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel model)
        {
			if (ModelState.IsValid)
			{
                AppRole role = new AppRole
                {
                    Name = model.RoleName,
                    NormalizedName = model.RoleName.ToUpper()
                };
                var result = await _roleManager.CreateAsync(role);
				if (result.Succeeded)
				{
                    return RedirectToAction("RoleList", "AdminRoles", new { area = "Admin" });
				}
			}
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
		{
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();
            TempData["userId"] = user.Id;
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach(var item in roles)
			{
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
			}
            return View(model);
		}
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
		{
            var userid =(int)TempData["userId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach(var item in model)
			{
				if (item.Exists)
				{
                    await _userManager.AddToRoleAsync(user, item.Name);
				}
				else
				{
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
				}
			}
            return RedirectToAction("UserRoleList", "AdminRoles", new { area = "Admin" });

        }
        public IActionResult UserRoleList()
		{
            var value = _userManager.Users.ToList();
            return View(value);
		}
    }
}
