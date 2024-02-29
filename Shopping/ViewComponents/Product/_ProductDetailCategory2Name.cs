using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Shopping.ViewComponents.Product
{
	public class _ProductDetailCategory2Name:ViewComponent
	{
		ICategory2Service _category2Service;
		Context _context;

		public _ProductDetailCategory2Name(ICategory2Service category2Service, Context context)
		{
			_category2Service = category2Service;
			_context = context;
		}
		public IViewComponentResult Invoke(int id)
		{
			var value = _context.Category2s.FirstOrDefault(x => x.Category2Id == id);
			return View(value);
		}
	}
}
