using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Shop
{
    public class _InShopAllProducts:ViewComponent
    {
        IProductService _productService;

        public _InShopAllProducts(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x =>x.ShopProductStatus== "Təsdiqləndi" && x.ProductStatus == "Active" && x.AppUser.MemberStatus== "Active").ToList();

            return View(value);
        }
    }
}
