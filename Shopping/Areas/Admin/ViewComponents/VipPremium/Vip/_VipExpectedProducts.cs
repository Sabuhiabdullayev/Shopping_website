using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Vip
{
    public class _VipExpectedProducts:ViewComponent
    {
        IProductService _productService;

        public _VipExpectedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_VipExpectedProducts();
            return View(value);
        }
    }
}
