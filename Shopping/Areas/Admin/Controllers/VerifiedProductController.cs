using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin,Moderator")]
	public class VerifiedProductController : Controller
	{
		IProductService _productService;

		public VerifiedProductController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult VipAllList()
		{
			return View();
		}
		public IActionResult PremiumAllList()
		{
			return View();
		}
		public IActionResult Premium(int id)
		{
			var Premium = _productService.TGetById(id);
			return View(Premium);
		}
		[HttpPost]
		public IActionResult PremiumVerified(Product p)
		{
			return View();
		}
		
		public IActionResult Vip(int id)
		{
			var Vip=_productService.TGetById(id);
			return View(Vip);
		}
		[HttpPost]
		public IActionResult VipVerified(Product p)
		{
			return View();
		}


	}
}
