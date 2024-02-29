using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.VipPremium.Vip
{
    public class _VipProductList:ViewComponent
    {
        IProductService _productService;

        public _VipProductList(IProductService productService)
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
