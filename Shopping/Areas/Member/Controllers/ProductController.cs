using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping.Areas.Member.Models;


namespace Shopping.Areas.Member.Controllers
{
    [Area("Member")]
    //  [Route("Member/{controller=Home}/{action=Index}/{id?}")]
    
    public class ProductController : Controller
    {
        UserManager<AppUser> _userManager;
        IProductService _productService;
        Context c = new Context();

        public ProductController(UserManager<AppUser> userManager, IProductService productService)
        {
            _userManager = userManager;
            _productService = productService;
        }

        public IActionResult MyProducts()
        {
           
            return View();
        }

        public JsonResult Category2json(int ID)
        {

            var catego = c.Category2s.Where(w => w.CatalogId == ID).ToList();
            return Json(new SelectList(catego, "Category2Id", "Category2Name"));
        }
        public JsonResult Category1json(int ID)
        {

            var categoryl = c.Categories.Where(w => w.Category2Id == ID).ToList();
            return Json(new SelectList(categoryl, "CategoryId", "CategoryName"));
        }


        [HttpGet]
        public IActionResult ProductAdd()
        {
                       ViewBag.catalog = new SelectList(c.Catalogs, "CatalogId", "CatalogName");


            ViewBag.City = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Agcabədi"},
                new SelectListItem{ Text="Ağdam"},
                new SelectListItem{ Text="Ağdaş"},
                new SelectListItem{ Text="Ağdərə"},
                new SelectListItem{ Text="Ağstafa"},
                new SelectListItem{ Text="Ağsu"},
                new SelectListItem{Text="Astara"},
                new SelectListItem{ Text="Bakı"},
                new SelectListItem{ Text="Balakən"},
                new SelectListItem{Text="Beylaqan"},
                new SelectListItem{ Text="Bərdə"},
                new SelectListItem{Text="Biləsuvar"},
                new SelectListItem{Text="Cəbrayıl"},
                new SelectListItem{ Text="Cəlilabad"},
                new SelectListItem{ Text="Culfa"},
                new SelectListItem{Text="Daşkəsən"},
                new SelectListItem{ Text="Füzuli"},
                new SelectListItem{Text="Gədəbəy"},
                new SelectListItem{ Text="Gəncə"},
                new SelectListItem{ Text="Goranboy"},
                new SelectListItem{Text="Göyçay"},
                new SelectListItem{ Text="Göygöl"},
                new SelectListItem{ Text="Göytəpə"},
                new SelectListItem{ Text="Hacıqabul"},
                new SelectListItem{ Text="Horadiz"},
                new SelectListItem{ Text="İmişli"},
                new SelectListItem{Text="İsmayıllı"},
                new SelectListItem{Text="Kəlbəcər"},
                new SelectListItem{Text="Kürdəmir"},
                new SelectListItem{Text="Laçın"},
                new SelectListItem{Text="Lerik"},
                new SelectListItem{Text="Lənkəran"},
                new SelectListItem{Text="Massallı"},
                new SelectListItem{Text="Mingəçəvir"},
                new SelectListItem{Text="Nabran"},
                new SelectListItem{Text="Naftalan"},
                new SelectListItem{Text="Naxçəvan"},
                new SelectListItem{Text="Neftçala"},
                new SelectListItem{Text="Oğuz"},
                new SelectListItem{Text="Ordubad"},
                new SelectListItem{Text="Qax"},
                new SelectListItem{Text="Qazax"},
                new SelectListItem{Text="Qəbələ"},
                new SelectListItem{Text="Qobustan"},
                new SelectListItem{Text="Quba"},
                new SelectListItem{Text="Qubadlı"},
                new SelectListItem{Text="Qusar"},
                new SelectListItem{Text="Saatlı"},
                new SelectListItem{Text="Sabirabad"},
                new SelectListItem{Text="Şabran"},
                new SelectListItem{Text="Şahbuz"},
                new SelectListItem{Text="Salyan"},
                new SelectListItem{Text="Şamaxı"},
                new SelectListItem{ Text="Samux"},
                new SelectListItem{ Text="Şəki"},
                new SelectListItem{ Text="Şəmkir"},
                new SelectListItem{ Text="Şərur"},
                new SelectListItem{ Text="Şirvan"},
                new SelectListItem{ Text="Siyəzən"},
                new SelectListItem{ Text="Sumqayıt"},
                new SelectListItem{ Text="Şuşa"},
                new SelectListItem{ Text="Tərtər"},
                new SelectListItem{ Text="Tovuz"},
                new SelectListItem{ Text="Ucar"},
                new SelectListItem{ Text="Xaçmaz"},
                new SelectListItem{ Text="Xankəndi"},
                new SelectListItem{ Text="Xırdalan"},
                new SelectListItem{ Text="Xızı"},
                new SelectListItem{ Text="Xocalı"},
                new SelectListItem{ Text="Xocavənd"},
                new SelectListItem{ Text="Xudat"},
                new SelectListItem{ Text="Yardımlı"},
                new SelectListItem{ Text="Yevlax"},
                new SelectListItem{ Text="Zaqatala"},
                new SelectListItem{ Text="Zəngilan"},
                new SelectListItem{ Text="Zərdab"}

            };
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductAdd(ProductUploadModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            Product p = new Product();

            p.AppUserId = user.Id;

            if (model.Image1Url != null)
            {
                var Extension = Path.GetExtension(model.Image1Url.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Image1Url.CopyTo(Stream);
                p.Image1 = newImageName;
            }

            if (model.Image2Url != null)
            {
                var Extension2 = Path.GetExtension(model.Image2Url.FileName);
                var newImageName2 = Guid.NewGuid() + Extension2;
                var Location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName2);
                var Stream2 = new FileStream(Location2, FileMode.Create);
                model.Image2Url.CopyTo(Stream2);
                p.Image2 = newImageName2;
            }
            else
            {
                p.Image2 = null;
            }
            if (model.Image3Url != null)
            {
                var Extension3 = Path.GetExtension(model.Image3Url.FileName);
                var newImageName3 = Guid.NewGuid() + Extension3;
                var Location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName3);
                var Stream3 = new FileStream(Location3, FileMode.Create);
                model.Image3Url.CopyTo(Stream3);
                p.Image3 = newImageName3;
            }
            else
            {
                p.Image3 = null;
            }
            if (model.Image4Url != null)
            {
                var Extension4 = Path.GetExtension(model.Image4Url.FileName);
                var newImageName4 = Guid.NewGuid() + Extension4;
                var Location4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName4);
                var Stream4 = new FileStream(Location4, FileMode.Create);
                model.Image4Url.CopyTo(Stream4);
                p.Image4 = newImageName4;
            }
            else
            {
                p.Image4 = null;
            }
            if (model.Image5Url != null)
            {
                var Extension5 = Path.GetExtension(model.Image5Url.FileName);
                var newImageName5 = Guid.NewGuid() + Extension5;
                var Location5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName5);
                var Stream5 = new FileStream(Location5, FileMode.Create);
                model.Image5Url.CopyTo(Stream5);
                p.Image5 = newImageName5;
            }
            else
            {
                p.Image5 = null;
            }
            if (model.Image6Url != null)
            {
                var Extension6 = Path.GetExtension(model.Image6Url.FileName);
                var newImageName6 = Guid.NewGuid() + Extension6;
                var Location6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName6);
                var Stream6 = new FileStream(Location6, FileMode.Create);
                model.Image6Url.CopyTo(Stream6);
                p.Image6 = newImageName6;
            }
            else
            {
                p.Image6 = null;
            }
            if (model.Image7Url != null)
            {
                var Extension7 = Path.GetExtension(model.Image7Url.FileName);
                var newImageName7 = Guid.NewGuid() + Extension7;
                var Location7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName7);
                var Stream7 = new FileStream(Location7, FileMode.Create);
                model.Image7Url.CopyTo(Stream7);
                p.Image7 = newImageName7;
            }
            else
            {
                p.Image7 = null;
            }
            if (model.Image8Url != null)
            {
                var Extension8 = Path.GetExtension(model.Image8Url.FileName);
                var newImageName8 = Guid.NewGuid() + Extension8;
                var Location8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName8);
                var Stream8 = new FileStream(Location8, FileMode.Create);
                model.Image8Url.CopyTo(Stream8);
                p.Image8 = newImageName8;
            }
            else
            {
                p.Image8 = null;
            }
            if (model.Image9Url != null)
            {
                var Extension9 = Path.GetExtension(model.Image9Url.FileName);
                var newImageName9 = Guid.NewGuid() + Extension9;
                var Location9 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName9);
                var Stream9 = new FileStream(Location9, FileMode.Create);
                model.Image9Url.CopyTo(Stream9);
                p.Image9 = newImageName9;
            }
            else
            {
                p.Image9 = null;
            }
            if (model.Image10Url != null)
            {
                var Extension10 = Path.GetExtension(model.Image10Url.FileName);
                var newImageName10 = Guid.NewGuid() + Extension10;
                var Location10 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName10);
                var Stream10 = new FileStream(Location10, FileMode.Create);
                model.Image10Url.CopyTo(Stream10);
                p.Image10 = newImageName10;
            }
            else
            {
                p.Image10 = null;
            }

            if (model.ProductName != null)
            {
                p.ProductName = model.ProductName;
            }
           
            if (model.CarMake != null)
            {
                p.CarMake = model.CarMake;
            }
            else
            {
                p.CarMake = null;
            }
            if (model.CarEngineBox != null)
            {
                p.CarEngineBox = model.CarEngineBox;
            }
            else
            {
                p.CarEngineBox = null;
            }
            if (model.Year != null)
            {
                p.Year = model.Year;
            }
            else
            {
                p.Year = null;
            }
            if (model.CarMileagekm != null)
            {
                p.CarMileagekm = model.CarMileagekm;
            }
            else
            {
                p.CarMileagekm = null;
            }
            if (model.LandForSale != null)
            {
                p.LandForSale = model.LandForSale;
            }
            else
            {
                p.LandForSale = null;
            }
            if (model.BuildingFloor != null)
            {
                p.BuildingFloor = model.BuildingFloor;
            }
            else
            {
                p.BuildingFloor = null;
            }
            if (model.Delivery == "on")
            {
                p.Delivery = "var";
            }
            else
            {
                p.Delivery = null;
            }
            if (model.VehicleFuelType != null)
            {
                p.VehicleFuelType = model.VehicleFuelType;
            }
            else
            {
                p.VehicleFuelType = null;
            }
            if (model.ProductModel != null)
            {
                p.ProductModel = model.ProductModel;
            }
            else
            {
                p.ProductModel = null;
            }

            if (model.CarBody != null)
            {
                p.CarBody = model.CarBody;
            }
            else
            {
                p.CarBody = null;
            }
            if (model.ProductNew == "on")
            {
                p.ProductNew = "Bəli";
            }
            else
            {
                p.ProductNew = null;
            }



            p.ProductOwnerName = null;

            p.Category2Id = model.Category2Id;

            p.Description = model.Description;
            p.City = model.City;

            p.Price = model.Price;
            p.PriceCurrency = model.PriceCurrency;
            p.Vip = "Təstiqlənməyib";
            p.Premium = "Təstiqlənməyib";
            p.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
            p.ProductStatus = "Active";
            p.Phone = model.Phone.ToString();
            p.Catalog = model.Catalog;
            p.MyProductStatus = "Active";
            if (model.CommentStatus == "on"){
                p.CommentStatus = "Active";
            }
            else
            {
                p.CommentStatus = "Passive";
            }
            if (model.WorkArea != null)
            {
                p.WorkArea = model.WorkArea;
            }

           
            if (model.WorkSchedule != null)
            {
                p.WorkSchedule = model.WorkSchedule;
            }
            if (model.WorkPlace != null)
            {
                p.WorkPlace=model.WorkPlace;
            }
            if (model.Edaction != null)
            {
                p.Edaction = model.Edaction;
            }
            if (model.AnimalSpecies != null)
            {
                p.AnimalSpecies = model.AnimalSpecies;
            }
            if (model.FeedsforAnimals != null)
            {
                p.FeedsforAnimals = model.FeedsforAnimals;
            }
            if (model.Gender != null)
            {
                p.Gender = model.Gender;
            }
            if (model.ClothingType != null)
            {
                p.ClothingType = model.ClothingType;
            }
            if (model.Size != null)
            {
                p.Size = model.Size;
            }
            if (model.BusinessArea != null)
            {
                p.BusinessArea = model.BusinessArea;
            }
            if (model.TypeOfGoods != null)
            {
                p.TypeOfGoods = model.TypeOfGoods;
            }
            if (model.Category1 != null)
            {
                p.Category1 = model.Category1;
            }
            else
            {
                p.Category1 = "null";
            }


            if (model.Phone2 != null)
            {
                p.Phone2 = model.Phone2;
            }
            else
            {
                p.Phone2 = null;
            }




            if (model.BuildingType == "on")
            {
                p.BuildingType = "Yeni tikili";
            }
            else
            {
                p.BuildingType = null;
            }
            if (model.Color != null)
            {
                p.Color = model.Color;
            }
            else
            {
                p.Color = null;
            }


            if (model.Fieldm2 != null)
            {
                p.Fieldm2 = model.Fieldm2;
            }
            else
            {
                p.Fieldm2 = null;
            }

            if (model.NumberOfRooms != null)
            {
                p.NumberOfRooms = model.NumberOfRooms;
            }
            else
            {
                p.NumberOfRooms = null;
            }


            if (model.PlaceOfResidence != null)
            {
                p.PlaceOfResidence = model.PlaceOfResidence;
            }
            else
            {
                p.PlaceOfResidence = null;
            }

            if (model.RentForSale != null)
            {
                p.RentForSale = model.RentForSale;
            }
            else
            {
                p.RentForSale = null;
            }

            _productService.TAdd(p);
            return RedirectToAction("MyProducts", "Product", new {area="Member"});
        }
        public IActionResult Remove(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDel(value);
            return RedirectToAction("MyProducts", "Product", new { area = "Member" });
        }

        public IActionResult Vip(int id)
        {
            var value = _productService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult VipVerified(Product p)
        {
            var value = _productService.TGetById(p.ProductId);
            value.Vip = "Gözlənilir";
            _productService.TUpdate(value);
            return RedirectToAction("MyProducts", "Product", new { area = "Member" });
        }

        public IActionResult Premium(int id)
        {
            var value = _productService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult PremiumVerified(Product p)
        {
            var value = _productService.TGetById(p.ProductId);
            value.Premium = "Gözlənilir";
            _productService.TUpdate(value);
            return RedirectToAction("MyProducts", "Product", new { area = "Member" });
        }


        public IActionResult Update(int? id)
        {
            if(id != null)
            {
                var value = _productService.TGetById(id);
                return View(value);
            }
            else
            {
                return NotFound();
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductUploadModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            Product p = new Product();

            p.AppUserId = user.Id;

            if (model.Image1Url != null)
            {
                var Extension = Path.GetExtension(model.Image1Url.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.Image1Url.CopyTo(Stream);
                p.Image1 = newImageName;
            }

            if (model.Image2Url != null)
            {
                var Extension2 = Path.GetExtension(model.Image2Url.FileName);
                var newImageName2 = Guid.NewGuid() + Extension2;
                var Location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName2);
                var Stream2 = new FileStream(Location2, FileMode.Create);
                model.Image2Url.CopyTo(Stream2);
                p.Image2 = newImageName2;
            }
            else
            {
                p.Image2 = null;
            }
            if (model.Image3Url != null)
            {
                var Extension3 = Path.GetExtension(model.Image3Url.FileName);
                var newImageName3 = Guid.NewGuid() + Extension3;
                var Location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName3);
                var Stream3 = new FileStream(Location3, FileMode.Create);
                model.Image3Url.CopyTo(Stream3);
                p.Image3 = newImageName3;
            }
            else
            {
                p.Image3 = null;
            }
            if (model.Image4Url != null)
            {
                var Extension4 = Path.GetExtension(model.Image4Url.FileName);
                var newImageName4 = Guid.NewGuid() + Extension4;
                var Location4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName4);
                var Stream4 = new FileStream(Location4, FileMode.Create);
                model.Image4Url.CopyTo(Stream4);
                p.Image4 = newImageName4;
            }
            else
            {
                p.Image4 = null;
            }
            if (model.Image5Url != null)
            {
                var Extension5 = Path.GetExtension(model.Image5Url.FileName);
                var newImageName5 = Guid.NewGuid() + Extension5;
                var Location5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName5);
                var Stream5 = new FileStream(Location5, FileMode.Create);
                model.Image5Url.CopyTo(Stream5);
                p.Image5 = newImageName5;
            }
            else
            {
                p.Image5 = null;
            }
            if (model.Image6Url != null)
            {
                var Extension6 = Path.GetExtension(model.Image6Url.FileName);
                var newImageName6 = Guid.NewGuid() + Extension6;
                var Location6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName6);
                var Stream6 = new FileStream(Location6, FileMode.Create);
                model.Image6Url.CopyTo(Stream6);
                p.Image6 = newImageName6;
            }
            else
            {
                p.Image6 = null;
            }
            if (model.Image7Url != null)
            {
                var Extension7 = Path.GetExtension(model.Image7Url.FileName);
                var newImageName7 = Guid.NewGuid() + Extension7;
                var Location7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName7);
                var Stream7 = new FileStream(Location7, FileMode.Create);
                model.Image7Url.CopyTo(Stream7);
                p.Image7 = newImageName7;
            }
            else
            {
                p.Image7 = null;
            }
            if (model.Image8Url != null)
            {
                var Extension8 = Path.GetExtension(model.Image8Url.FileName);
                var newImageName8 = Guid.NewGuid() + Extension8;
                var Location8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName8);
                var Stream8 = new FileStream(Location8, FileMode.Create);
                model.Image8Url.CopyTo(Stream8);
                p.Image8 = newImageName8;
            }
            else
            {
                p.Image8 = null;
            }
            if (model.Image9Url != null)
            {
                var Extension9 = Path.GetExtension(model.Image9Url.FileName);
                var newImageName9 = Guid.NewGuid() + Extension9;
                var Location9 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName9);
                var Stream9 = new FileStream(Location9, FileMode.Create);
                model.Image9Url.CopyTo(Stream9);
                p.Image9 = newImageName9;
            }
            else
            {
                p.Image9 = null;
            }
            if (model.Image10Url != null)
            {
                var Extension10 = Path.GetExtension(model.Image10Url.FileName);
                var newImageName10 = Guid.NewGuid() + Extension10;
                var Location10 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductImg2/" + newImageName10);
                var Stream10 = new FileStream(Location10, FileMode.Create);
                model.Image10Url.CopyTo(Stream10);
                p.Image10 = newImageName10;
            }
            else
            {
                p.Image10 = null;
            }

            if (model.ProductName != null)
            {
                p.ProductName = model.ProductName;
            }
            else
            {
                p.ProductName = null;
            }
            if (model.CarMake != null)
            {
                p.CarMake = model.CarMake;
            }
            else
            {
                p.CarMake = null;
            }
            if (model.CarEngineBox != null)
            {
                p.CarEngineBox = model.CarEngineBox;
            }
            else
            {
                p.CarEngineBox = null;
            }
            if (model.Year != null)
            {
                p.Year = model.Year;
            }
            else
            {
                p.Year = null;
            }
            if (model.CarMileagekm != null)
            {
                p.CarMileagekm = model.CarMileagekm;
            }
            else
            {
                p.CarMileagekm = null;
            }
            if (model.LandForSale != null)
            {
                p.LandForSale = model.LandForSale;
            }
            else
            {
                p.LandForSale = null;
            }
            if (model.BuildingFloor != null)
            {
                p.BuildingFloor = model.BuildingFloor;
            }
            else
            {
                p.BuildingFloor = null;
            }
            if (model.Delivery != null)
            {
                p.Delivery = model.Delivery;
            }
            else
            {
                p.Delivery = null;
            }
            if (model.VehicleFuelType != null)
            {
                p.VehicleFuelType = model.VehicleFuelType;
            }
            else
            {
                p.VehicleFuelType = null;
            }
            if (model.ProductModel != null)
            {
                p.ProductModel = model.ProductModel;
            }
            else
            {
                p.ProductModel = null;
            }

            if (model.CarBody != null)
            {
                p.CarBody = model.CarBody;
            }
            else
            {
                p.CarBody = null;
            }
            if (model.ProductNew != null)
            {
                p.ProductNew = model.ProductNew;
            }
            else
            {
                p.ProductNew = null;
            }


            if (model.ProductOwnerName != null)
            {
                p.ProductOwnerName = model.ProductOwnerName;
            }
            
            p.Category2Id = model.Category2Id;
            p.MyProductStatus = "Active";
            p.Description = model.Description;
            p.City = model.City;

            p.Price = model.Price;
            p.PriceCurrency = model.PriceCurrency;
            p.Vip = "Təstiqlənməyib";
            p.Premium = "Təstiqlənməyib";
            p.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
            p.ProductStatus = "Təstiqləndi";
            p.Phone = model.Phone.ToString();
            if (model.Phone2 != null)
            {
                p.Phone2 = model.Phone2.ToString();
            }
            else
            {
                p.Phone2 = null;
            }




            if (model.BuildingType != null)
            {
                p.BuildingType = model.BuildingType;
            }
            else
            {
                p.BuildingType = null;
            }
            if (model.Color != null)
            {
                p.Color = model.Color;
            }
            else
            {
                p.Color = null;
            }


            if (model.Fieldm2 != null)
            {
                p.Fieldm2 = model.Fieldm2;
            }
            else
            {
                p.Fieldm2 = null;
            }

            if (model.NumberOfRooms != null)
            {
                p.NumberOfRooms = model.NumberOfRooms;
            }
            else
            {
                p.NumberOfRooms = null;
            }


            if (model.PlaceOfResidence != null)
            {
                p.PlaceOfResidence = model.PlaceOfResidence;
            }
            else
            {
                p.PlaceOfResidence = null;
            }

            if (model.RentForSale != null)
            {
                p.RentForSale = model.RentForSale;
            }
            else
            {
                p.RentForSale = null;
            }

            _productService.TUpdate(p);
            return RedirectToAction("MyProducts", "Product", new { area = "Member" });

        }
       [HttpPost]
        public IActionResult MyProductStatusUpdate(Product p)
        {
            var value = _productService.TGetById(p.ProductId);
            value.MyProductStatus = p.MyProductStatus;
            _productService.TUpdate(value);
            return RedirectToAction("MyProducts", "Product", new { area = "Member" });

        }
    }
}



