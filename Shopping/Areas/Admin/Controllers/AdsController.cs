using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.Ads;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Authorize(Roles = "Admin,Moderator")]
    public class AdsController : Controller
    {
        IAdsService _adsService;

        public AdsController(IAdsService adsService)
        {
            _adsService = adsService;
        }

        public IActionResult AdsList()
        {
            return View();
        }

       

        public IActionResult AdsDelete(int id)
        {
           var delete= _adsService.TGetById(id);
            _adsService.TDel(delete);
            return RedirectToAction("AdsList", "Ads", new { area = "Admin" });
        }

        public IActionResult Update(int id)
        {
            var value = _adsService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AdvertUpdate(AddAdvertViewModel model)
        {
            Ads ads = new Ads()
            {
                Name = model.Name,
                SurName = model.SurName,
                Email = model.Email,
                Phone = model.Phone,
                StartDate = model.StartDate,
                ExpiryDate = model.ExpiryDate,
                AdsDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                AdsStatus = "Aktiv"
            };

            if (model.Img1 != null)
            {
                var Extension = Path.GetExtension(model.Img1.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/NavbarAds/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Img1.CopyTo(Stream);
                ads.Img1 = newImageName;
            }
            if (model.Img2 != null)
            {
                var Extension = Path.GetExtension(model.Img2.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/NavbarAds/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Img2.CopyTo(Stream);
                ads.Img2 = newImageName;
            }
            if (model.Img3 != null)
            {
                var Extension = Path.GetExtension(model.Img3.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/NavbarAds/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Img3.CopyTo(Stream);
                ads.Img3 = newImageName;
            }
            _adsService.TAdd(ads);
            return RedirectToAction("AdsList", "Ads", new { area = "Admin" });
        }
    
  
    }
}
