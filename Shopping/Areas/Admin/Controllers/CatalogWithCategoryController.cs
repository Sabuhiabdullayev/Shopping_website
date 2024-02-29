using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CatalogWithCategoryController : Controller
    {
      private readonly Context _c;
        private readonly ICatalogService _catalogService;
        private readonly ICategory2Service _category2Service;
        private readonly ICategoryService _categoryService;

		public CatalogWithCategoryController(Context c, ICatalogService catalogService, ICategory2Service category2Service, ICategoryService categoryService)
		{
			_c = c;
			_catalogService = catalogService;
			_category2Service = category2Service;
			_categoryService = categoryService;
		}

		public IActionResult Insert()
        {
            ViewBag.catalog = new SelectList(_c.Catalogs, "CatalogId", "CatalogName");

            return View();
        }
        public IActionResult Update()
        {
            ViewBag.catalog = new SelectList(_c.Catalogs, "CatalogId", "CatalogName");

            return View();
        }
        public IActionResult Remove()
        {
            ViewBag.catalog = new SelectList(_c.Catalogs, "CatalogId", "CatalogName");

            return View();
        }
        public JsonResult Category2json(int ID)
        {

            var catego = _c.Category2s.Where(w => w.CatalogId == ID).ToList();
            return Json(new SelectList(catego, "Category2Id", "Category2Name"));
        }
        public JsonResult Category1json(int ID)
        {

            var catego = _c.Categories.Where(w => w.Category2Id == ID).ToList();
            return Json(new SelectList(catego, "CategoryId", "CategoryName"));
        }
        [HttpPost]
        public IActionResult CatalogAdd(Catalog catalog)
		{
             _catalogService.TAdd(catalog);
            var json = JsonConvert.SerializeObject(catalog);
            return Json(json);
		}

        [HttpPost]
        public IActionResult Category2Add(Category2 category2)
		{
            _category2Service.TAdd(category2);
            var json = JsonConvert.SerializeObject(category2);
            return Json(json);
		}

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            _categoryService.TAdd(category);
            var json = JsonConvert.SerializeObject(category);
            return Json(json);
        }
       

       
        [HttpPost]
        public IActionResult CatalogUpdate(Catalog catalog)
        {
            _catalogService.TUpdate(catalog);
            var json = JsonConvert.SerializeObject(catalog);
            return Json(json);
        }

        [HttpPut]
        public IActionResult Category2Update(Category2 category2)
        {
            _category2Service.TUpdate(category2);
            var json = JsonConvert.SerializeObject(category2);
            return Json(json);
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category category)
        {
            _categoryService.TUpdate(category);
            var json = JsonConvert.SerializeObject(category);
                return Json(json);
        }

        [HttpPost]
        public IActionResult CatalogRemove(int id)
        {
            var GetId = _catalogService.TGetById(id);
            _catalogService.TDel(GetId);
            return Json(GetId);
        }

        [HttpPost]
        public IActionResult Category2Remove(int id)
        {
            var GetId = _category2Service.TGetById(id);
            _category2Service.TDel(GetId);
           return Json(GetId);
        }

        [HttpPost]
        public IActionResult CategoryRemove(int id)
        {
            var GetId = _categoryService.TGetById(id);
            _categoryService.TDel(GetId);
            return Json(GetId);
        }
    }
}
