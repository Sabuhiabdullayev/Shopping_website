using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Concrete;
using BusinessLayer.Abstract;
namespace Shopping.Areas.Member.ViewComponents.Product
{
    public class _MyProductList:ViewComponent
    {
        UserManager<AppUser> _userManager;
        IProductService _productService;

        public _MyProductList(UserManager<AppUser> userManager, IProductService productService)
        {
            _userManager = userManager;
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _productService.TGetIncludeListProducts().Where(x=>x.AppUserId==user.Id);
            return View(value);
        }
    }
}
