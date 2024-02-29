using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Vip
{
    public class _VipUnapprovedProducts:ViewComponent
    {
        IProductService _productService;

        public _VipUnapprovedProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.T_VipUnapprovedProducts();
            return View(value);
        }
    }
}
