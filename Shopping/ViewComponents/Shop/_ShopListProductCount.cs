using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Shop
{
    public class _ShopListProductCount:ViewComponent
    {
    
        IProductService _productService;

        public _ShopListProductCount(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x => x.ShopProductStatus != null).ToList();
            return View(value);
        }
    }
}
  