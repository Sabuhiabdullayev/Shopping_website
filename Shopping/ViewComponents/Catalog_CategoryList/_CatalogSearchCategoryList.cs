
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Catalog_CategoryList
{
    public class _CatalogSearchCategoryList : ViewComponent
    {
        ICategory2Service _category2Service;

        public _CatalogSearchCategoryList(ICategory2Service category2Service)
        {
            _category2Service = category2Service;
        }

        public IViewComponentResult Invoke(string Name)
        {
            var List =_category2Service.TGetList().Where(x=>x.Catalog.CatalogName==Name).ToList();
            ViewBag.CatalogName = Name;
            return View(List);
        }
    }
}
