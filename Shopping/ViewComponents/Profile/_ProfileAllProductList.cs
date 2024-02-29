using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Profile
{
    public class _ProfileAllProductList:ViewComponent
    {
        IProductService _productService;

        public _ProfileAllProductList(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x=>x.ShopProductStatus == null && x.ProductStatus == "Active").ToList();
           
            return View(value);
        }
    }
}
