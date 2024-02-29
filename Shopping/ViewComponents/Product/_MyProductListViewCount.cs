using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Product
{
    public class _ProfileProductListViewCount:ViewComponent
    {
        IProductViewService _productViewService;

        public _ProfileProductListViewCount(IProductViewService productViewService)
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
