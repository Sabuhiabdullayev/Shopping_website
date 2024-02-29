using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Premium
{
    public class _PremiumUnapprovedProducts:ViewComponent
    {
        IProductService _productService;

        public _PremiumUnapprovedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_PremiumUnapprovedProducts();
            return View(value);
        }
    }
}
