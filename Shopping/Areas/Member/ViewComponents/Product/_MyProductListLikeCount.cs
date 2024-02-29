using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.Product
{
    public class _MyProductListLikeCount : ViewComponent
    {
        IProductLikeService _productLikeService;

        public _MyProductListLikeCount(IProductLikeService productLikeService)
        {
            _productLikeService = productLikeService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var view = _productLikeService.TGetList().Where(x => x.ProductId == id);
            return View(view);
        }
    }
}
