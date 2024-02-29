using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Premium
{
    public class _PremiumProductList:ViewComponent
    {
        IProductService _productService;

        public _PremiumProductList(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var value = _productService.TGetIncludeListProducts();
            return View(value);
        }
    }
}
