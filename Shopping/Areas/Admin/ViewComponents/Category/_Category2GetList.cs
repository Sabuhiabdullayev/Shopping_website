using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Category
{
    public class _Category2GetList:ViewComponent
    {
        Context _context;

        public _Category2GetList(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
       
            return View();
        }
    }
}
