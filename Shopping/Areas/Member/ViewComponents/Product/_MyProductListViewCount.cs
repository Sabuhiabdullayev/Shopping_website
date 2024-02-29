using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.Product
{
    public class _MyProductListViewCount:ViewComponent
    {
        IProductViewService _productViewService;

        public _MyProductListViewCount(IProductViewService productViewService)
        {
            _productViewService = productViewService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var view = _productViewService.TGetList().Where(x => x.ProductId == id);
            return View(view);
        }
    }
}
