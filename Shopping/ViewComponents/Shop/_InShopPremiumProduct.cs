using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Shop
{
    public class _InShopPremiumProduct:ViewComponent
    {
        IProductService _productService;

        public _InShopPremiumProduct(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x => x.ShopProductStatus == "Təsdiqləndi" && x.Premium == "Təsdiqləndi" && x.ProductStatus == "Active").ToList();

            return View(value);
        }
    }
}
