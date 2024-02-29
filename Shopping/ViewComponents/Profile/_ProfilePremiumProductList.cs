using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Profile
{
    public class _ProfilePremiumProductList:ViewComponent
    {

        IProductService _productService;

        public _ProfilePremiumProductList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x =>x.ShopProductStatus==null && x.Premium == "Təsdiqləndi" && x.ProductStatus == "Active").ToList();

            return View(value);
        }
    }
}
