using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Member.Models;
using Shopping.Models;

namespace Shopping.Areas.Member.Controllers
{
    [Area("Member")]
//    [Route("Member/{controller=Home}/{action=Index}/{id?}")]
 
    public class ProfileController : Controller
    {
        UserManager<AppUser> _userManager;
        IProductService _productService;

       
        Context c = new Context();

        public ProfileController(UserManager<AppUser> userManager, IProductService productService)
        {
            _userManager = userManager;
            _productService = productService;
        }

      
      
        [HttpGet]
        public async Task<IActionResult> Settings()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileUpdateViewModel userModel = new ProfileUpdateViewModel();
            userModel.UserName = values.UserName;
            userModel.Name = values.Name;
            userModel.SurName = values.SurName;
            userModel.Email = values.Email;
            userModel.ImageUrl = values.ImageUrl;
            userModel.Genger = values.Genger;


            return View(userModel);
        }
        [HttpPost]
        public async Task<IActionResult> Settings(AppUserViewModel p)
        {
          
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.ImageSmall != null)
            {
                var resurs = Directory.GetCurrentDirectory();
                var Extinsion = Path.GetExtension(p.ImageSmall.FileName);
                var NewName = Guid.NewGuid() + Extinsion;
                var SaveLocation = resurs + "/wwwroot/Shopping/MemBerImg/" + NewName;
                var Stream = new FileStream(SaveLocation, FileMode.Create);
                await p.ImageSmall.CopyToAsync(Stream);
                user.ImageUrl = NewName;
            }

            user.Name = p.Name;
            user.SurName = p.SurName;
            user.UserName = p.UserName;
            user.Genger = p.Genger;
            user.Email = p.Email;

            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                return RedirectToAction("SignIn", "Login");
            }
            return View(p);

        }
        [HttpGet]
        public async Task<IActionResult> MyConfirmed()
        {
            var confirmed = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Confirmed = confirmed.confirmed.ToString();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MyConfirmed(ConfirmedViewModel p)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
         

            user.Name = p.Name;
            user.SurName = p.SurName; 
            user.Email = p.Email;
            user.MemberMessage=p.Message;
           
            user.PhoneNumber = p.Phone;
            user.confirmed = ("Yoxlanılır").ToString();
          
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                return RedirectToAction("MyConfirmed", "Profile", new {area="Member"});
            }
            return View(p);

        }
        [HttpGet]
        public PartialViewResult MemberDescription()
        {
            return PartialView();
        }

        //[HttpPost]
        //public IActionResult MemberDescription()
        //{
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    if (p.ImageUrl != null)
        //    {
        //        var resurs = Directory.GetCurrentDirectory();
        //        var Extinsion = Path.GetExtension(p.ImageUrl.FileName);
        //        var NewName = Guid.NewGuid() + Extinsion;
        //        var SaveLocation = resurs + "/wwwroot/Shopping/MemBerImg/" + NewName;
        //        var Stream = new FileStream(SaveLocation, FileMode.Create);
        //        await p.ImageUrl.CopyToAsync(Stream);
        //        user.ImageUrl = NewName;
        //    }

        //    user.Name = p.Name;
        //    user.SurName = p.SurName;
        //    user.UserName = p.UserName;
        //    user.Genger = p.Genger;
        //    user.Email = p.Email;

        //    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
        //    var result = await _userManager.UpdateAsync(user);
        //    if (result.Succeeded)
        //    {

        //        return RedirectToAction("SignIn", "Login");
        //    }
        //    return View(p);
        //}

    }

    }




