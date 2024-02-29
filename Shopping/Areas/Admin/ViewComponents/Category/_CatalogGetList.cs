using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shopping.Areas.Admin.ViewComponents.Category
{
    public class _CatalogGetList:ViewComponent
    {
   
        Context _context;
        public _CatalogGetList( Context context)
        {
   
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> values = (from x in _context.Catalogs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CatalogName,
                                               Value = x.CatalogId.ToString()
                                           }).ToList();
            ViewBag.Catalog = values;
            return View();
        }
    }
}
