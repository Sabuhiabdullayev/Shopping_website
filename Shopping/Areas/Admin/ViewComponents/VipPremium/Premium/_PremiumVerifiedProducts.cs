using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Premium
{
    public class _PremiumVerifiedProducts:ViewComponent
    {
        IProductService _productService;

        public _PremiumVerifiedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_PremiumVerifiedProducts();
            return View(value);
        }
    }
}
