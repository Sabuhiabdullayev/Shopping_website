using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Vip
{
    public class _VipVerifiedProducts:ViewComponent
    {
        IProductService _productService;

        public _VipVerifiedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_VipVerifiedProducts();
            return View(value);
        }
    }
}
