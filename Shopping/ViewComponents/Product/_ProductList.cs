using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Shopping.ViewComponents
{
    public class _ProductList:ViewComponent
    {
        IProductService _productService;
        Context c = new Context();
        public _ProductList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productService.TGetIncludeListProducts().Where(x=>x.ProductStatus == "Active" && x.AppUser.MemberStatus== "Active" && x.MyProductStatus== "Active");
            return View(value);
        }
    }
}
