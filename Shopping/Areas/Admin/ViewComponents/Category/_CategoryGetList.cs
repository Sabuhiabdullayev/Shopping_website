using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Category
{
    public class _CategoryGetList:ViewComponent
    {
        ICategoryService _categoryService;

        public _CategoryGetList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var GetList = _categoryService.TGetList();
            return View(GetList);
        }
    }
}
