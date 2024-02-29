using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.ProductDetail
{
    public class _ProductDetailFooterDescription : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductDetailFooterDescription(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var GetById = _productService.TGetById(id);
            return View(GetById);
        }
    }
}
