using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Product
{
	public class _ProductListAppUserConfirm:ViewComponent
	{
		IProductService _productService;

        public _ProductListAppUserConfirm(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
         var value =  _productService.TGetIncludeListProducts().Where(x =>x.ProductStatus == "Active" && x.AppUser.MemberStatus== "Active" && x.AppUser.confirmed=="Təsdiqləndi" && x.MyProductStatus == "Active").ToList();
            return View(value);
        }
    }
}
