using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Profile
{
    public class _ProfileVipProductList:ViewComponent
    {

        IProductService _productService;

        public _ProfileVipProductList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x =>x.ShopProductStatus==null && x.Vip == "Təsdiqləndi" && x.ProductStatus == "Active").ToList();

            return View(value);
        }
    }
}
