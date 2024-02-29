using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Premium
{
    public class _PremiumExpectedProducts:ViewComponent
    {
        IProductService _productService;

        public _PremiumExpectedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_PremiumExpectedProducts();
            return View(value);
        }
    }
}
