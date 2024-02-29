using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shopping.Areas.Member.Models;
using Shopping.Models;
using Shopping.Models.Product;
using X.PagedList;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        Context context = new Context();

       
        public IActionResult AllProductPage()
        {
            return View();
        }

        public IActionResult Search(SearchViewModel p)
        {
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
            if (p.Search != null)
            {
                ViewBag.Search = p.Search.ToString() +" -";
            }
            else
            {
                ViewBag.Search = " ";
            }

            ViewData["CurrentFilter"] = p.Search;
            var Product = from b in context.Products.Include(y=>y.AppUser).Where(x=>x.AppUser.MemberStatus=="Active" && x.ProductStatus=="Active" && x.MyProductStatus=="Active")
                          select b;
            if (!string.IsNullOrEmpty(p.Search))
            {
                Product = Product.Include(y=>y.AppUser).Where(b => b.ProductName.Contains(p.Search) && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" &&b.MyProductStatus == "Active");

            }
            if (!string.IsNullOrEmpty(p.City))
            {
                Product = Product.Include(y => y.AppUser).Where(b => b.City.Contains(p.City) && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

            }
            if (!string.IsNullOrEmpty(p.Catalog))
            {
                Product = Product.Include(y => y.AppUser).Where(b => b.Catalog.Contains(p.Catalog) && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active"&&b.MyProductStatus == "Active");

            }
            if (!string.IsNullOrEmpty(p.PriceStatus))
            {
                if (p.PriceStatus == "Cheap")
                {
                    Product = Product.Include(y => y.AppUser).OrderBy(b => b.Price).Where(b=>b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

                }
                else if (p.PriceStatus == "Expensive")
                {
                    Product = Product.Include(y => y.AppUser).OrderByDescending(b => b.Price).Where(b => b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

                }
            }
            if (p.Min != 0 || p.Max != 0 || p.Min != 0 && p.Max != 0)
                {
                    if (p.Min != 0 && p.Max != 0)
                    {
                        Product = Product.Where(b => b.Price >= p.Min && b.Price <= p.Max && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");
                    }
                    else if (p.Min != 0 && p.Max == 0)
                    {
                        Product = Product.Where(b => b.Price > p.Min && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

                    }
                    else if (p.Max != 0 && p.Min == 0)
                    {
                        Product = Product.Where(b => b.Price < p.Max && b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

                    }
                }

           
            if (!string.IsNullOrEmpty(p.Date))
            {
                if (p.Date == "Old")
                {
                    Product = Product.Include(y => y.AppUser).OrderBy(b => b.Date).Where(b=> b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");

                }
                else if (p.Date == "New")
                {
                    Product = Product.Include(y => y.AppUser).OrderByDescending(b => b.Date).Where(b => b.AppUser.MemberStatus == "Active" && b.ProductStatus == "Active" && b.MyProductStatus == "Active");


                }
            }
              
                return View(Product);
            
        }
      
        public IActionResult Error404(int Code)
        {
            return View();
        }
       public IActionResult Cascading()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetCatalog()
        {
            var catalogs = context.Catalogs.Select(c => new SelectListItem()
            {
                Value = c.CatalogId.ToString(),
                Text = c.CatalogName
            });
            return Json(catalogs);
        }
        public IActionResult GetCategory2(int catalogId)
        {
            var category2s = context.Category2s.Where(s => s.CatalogId == catalogId)
                .Select(s => new SelectListItem()
                {
                    Value = s.Category2Id.ToString(),
                    Text=s.Category2Name
                });
            return Json(category2s);
        }

        public IActionResult GetCategory(int category2Id)
        {
            var categorys = context.Categories.Where(c => c.Category2Id == category2Id)
                .Select(c => new SelectListItem()
                {
                    Value = c.CategoryId.ToString(),
                    Text=c.CategoryName
                });
            return Json(categorys);
        }

    }
}
