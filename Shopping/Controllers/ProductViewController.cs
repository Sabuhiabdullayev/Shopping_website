using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class ProductViewController : Controller
    {
        private readonly IProductViewService _productViewService;
        private readonly Context _context;

        public ProductViewController(IProductViewService productViewService, Context context)
        {
            _productViewService = productViewService;
            _context = context;
        }

        public IActionResult ViewList(int id)
        {
            var list = _productViewService.TGetList().Where(x => x.ProductId == id);
            var json = JsonConvert.SerializeObject(list);
            return Json(json);
        }
        [HttpPost]
        public IActionResult ViewAdd(ProductView  productView)
        {
            productView.NumberOfProductViews = 1;
            _productViewService.TAdd(productView);
            var json = JsonConvert.SerializeObject(productView);
            return Json(json);
        }

        [HttpPost]
        public IActionResult ViewUpdate(ProductView productView)
        {
            _productViewService.TUpdate(productView);
            var json = JsonConvert.SerializeObject(productView);
            return Json(json);
        }
        public IActionResult AllDelete()
        {

            IEnumerable<ProductView> view = _context.ProductViews.Take(10000).ToList();
            _context.ProductViews.RemoveRange(view);
            _context.SaveChanges();
            return RedirectToAction("AllProductPage","Home");
        }
    }
}
