using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserViewModel p)
        {

            AppUser appUser = new AppUser()
            {
                UserName = p.UserName,
                Name = p.Name,
                SurName = p.SurName,
                Email = p.Email,
                Genger = p.Genger,
                MemberMessage = null,
                confirmed = "Təstiqlənməyib",
                AppUserDate = DateTime.Parse(DateTime.Now.ToShortTimeString()),
                MemberStatus = "Active",
                ShopConfirmed = "Təstiqlənməyib",
                ShopStatus = "Passive",
                Dateofbirth = null,
            
                PhoneNumber=p.Phone
                



            };
            
            if(p.ImageSmall != null)
            {
                var Extinsion = Path.GetExtension(p.ImageSmall.FileName);
                var NewName = Guid.NewGuid() + Extinsion;
                var Location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/Shopping/MemberImg/" + NewName);
                var Stream = new FileStream(Location, FileMode.Create);
                p.ImageSmall.CopyTo(Stream);
                appUser.ImageUrl =NewName;
            }
            else
            {
                appUser.ImageUrl = "/DefaultImg/Default.png".ToString();
            }
            if (p.ImageBig != null)
            {
                var Extinsion = Path.GetExtension(p.ImageBig.FileName);
                var NewName = Guid.NewGuid() + Extinsion;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/MemberBigimg/" + NewName);
                var Stream = new FileStream(Location, FileMode.Create);
                p.ImageBig.CopyTo(Stream);
                appUser.BigImageUrl = NewName;
            }
            else
            {
                appUser.ImageUrl = "/DefaultImg/Default.png".ToString();
            }
            if (p.Password == p.ConfigPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    if (!ModelState.IsValid)
                    {
                        var v = ModelState.ToList();
                        ViewBag.value = v;
                    }
                }
            }
            return View(p);

        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel p,string returnUrl)
        {
            var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                return RedirectToAction("MyProducts", "Product", new { area = "Member" });

                }
            }

            return View(p);
        }

        

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("AllProductPage", "home");
        }
    }
}
