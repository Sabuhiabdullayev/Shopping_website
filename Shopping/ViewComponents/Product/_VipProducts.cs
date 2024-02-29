using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Product
{
    public class _VipProducts : ViewComponent
    {
        IProductService _productService;

		public _VipProducts(IProductService productService)
		{
			_productService = productService;
		}

		public IViewComponentResult Invoke()
        {
            var value = _productService.TGetIncludeListProducts().Where(x => x.Vip == "Təsdiqləndi" &&  x.ProductStatus == "Active" && x.AppUser.MemberStatus== "Active" || x.Premium== "Təsdiqləndi" && x.ProductStatus == "Active" && x.AppUser.MemberStatus == "Active" && x.MyProductStatus == "Active").ToList();
            return View(value);
        }
    }
}
