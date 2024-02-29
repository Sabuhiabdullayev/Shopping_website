using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.Shop
{
    public class _MyShopProduct:ViewComponent
    {
        IProductService _productService;

        public _MyShopProduct(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
       var value = _productService.TGetIncludeListProducts().Where(x => x.ShopProductStatus == "Təsdiqləndi");
       return View(value);
        }
    }
}
