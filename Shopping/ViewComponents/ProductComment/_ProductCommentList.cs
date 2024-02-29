using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.ProductComment
{
    public class _ProductCommentList:ViewComponent
    {

        IProductCommentService _productCommentService;

        public _ProductCommentList(IProductCommentService productCommentService)
        {
            _productCommentService = productCommentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _productCommentService.TGetCommentlistById(id).OrderBy(x=>x.ProductCommentDate);
            return View(value);
        }
    }
}
