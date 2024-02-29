using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.ProductDetail
{
    public class _ProductDetailProductList:ViewComponent
    {
        UserManager<AppUser> _userManager;
        IProductService _productService;

        public _ProductDetailProductList(UserManager<AppUser> userManager, IProductService productService)
        {
            _userManager = userManager;
            _productService = productService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var value = _productService.TGetIncludeListProducts().Where(x => x.ProductStatus == "Active" && x.AppUser.MemberStatus == "Active" && x.Category2Id==id);
            return View(value);
        }
    }
}
