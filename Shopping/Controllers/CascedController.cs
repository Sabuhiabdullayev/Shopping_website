using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping.Models;


namespace Shopping.Controllers
{
   [AllowAnonymous]
    public class CascedController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
     public JsonResult Category2json(int ID)
        {

            var catego = c.Category2s.Where(w => w.CatalogId == ID).ToList();
            return Json(new SelectList(catego, "Category2Id", "Category2Name"));
        }
        public JsonResult Category1json(int ID)
        {

            var catego = c.Categories.Where(w => w.Category2Id == ID).ToList();
            return Json(new SelectList(catego, "CategoryId", "CategoryName"));
        }

        public IActionResult Cascade()
        {
            ViewBag.catalog = new SelectList(c.Catalogs, "CatalogId", "CatalogName");
            
            return View();
        }
    }
}
