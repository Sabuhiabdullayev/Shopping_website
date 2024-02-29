using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.User
{
    public class _MemberListProductCount:ViewComponent
    {
        IProductService _productService;

        public _MemberListProductCount(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.GetListByFilter(id).Where(x => x.ShopProductStatus == null).ToList();
            return View(value);
        }
    }
}
