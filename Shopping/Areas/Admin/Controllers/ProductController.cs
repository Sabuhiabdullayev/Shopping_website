using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping.Areas.Admin.Models.Product;
using X.PagedList;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ProductController : Controller
    {
        IProductService _productService;
        Context _context;

        public ProductController(IProductService productService,Context context)
        {
            _productService = productService;
            _context = context;
        }

        public IActionResult AllProducts()
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
            var Getlist=  _productService.TGetList();
            return View(Getlist);
        }
        public IActionResult Search(ProductSearchViewModel p)
        {
            ViewData["CurrentFilter"] = p.ProductName;
            var Product = from b in _context.Products
                          select b;
            if (!string.IsNullOrEmpty(p.ProductName))
            {
                Product = Product.Where(b => b.ProductName.Contains(p.ProductName));

            }
          
                if (!string.IsNullOrEmpty(p.City))
                {
                        Product = Product.Where(b => b.City.Contains(p.City));

                }




            if (!string.IsNullOrEmpty(p.Status))
            {
                Product = Product.Where(b => b.ProductStatus.Contains(p.Status));

            }


            if (p.PriceMin!=0 || p.PriceMax!=0 || p.PriceMin != 0 && p.PriceMax != 0)
            {
                if(p.PriceMin != 0 && p.PriceMax != 0)
                {
                    Product = Product.Where(b => b.Price >= p.PriceMin &&b.Price<=p.PriceMax);
                }else if(p.PriceMin != 0 && p.PriceMax == 0)
                {
                    Product = Product.Where(b => b.Price > p.PriceMin);

                }
                else if(p.PriceMax != 0 && p.PriceMin == 0)
                {
                    Product = Product.Where(b => b.Price < p.PriceMax);

                }
            }
            //if (p.DateMin !=null)
            //{
            //        Product = Product.Where(b => b.Date.Date>p.DateMin.Date);   
            //}
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


            return View(Product);
        }
        public IActionResult VipProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VipStatus(Product p)
        {
            var value = _productService.TGetById(p.ProductId);
            value.Vip = p.Vip;
            _productService.TUpdate(value);
            return RedirectToAction("VipProduct", "Product", new {area="Admin"});
        }
        public IActionResult VipTheAdd(int id)
        {
         var value= _productService.TGetById(id);
            return View(value);
        }

        public IActionResult PremiumProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PremiumStatus(Product p)
        {
            var value = _productService.TGetById(p.ProductId);
            value.Premium = p.Premium;
            _productService.TUpdate(value);
            return RedirectToAction("PremiumProduct", "Product", new { area = "Admin" });
        }
        [HttpPost]
       public IActionResult ProductStatus(Product p)
        {
            var values = _productService.TGetById(p.ProductId);
            values.ProductStatus = p.ProductStatus;
            _productService.TUpdate(values);
            return RedirectToAction("AllProducts", "Product", new { Area = "Admin" });
        } 
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var getid = _productService.TGetById(id);
            _productService.TDel(getid);
            return Json(getid);
        }
        public  IActionResult Products()
        {
            var list = _productService.TGetList();
            return View(list);
        }
    }
}
