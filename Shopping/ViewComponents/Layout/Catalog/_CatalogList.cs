using Microsoft.AspNetCore.Mvc;
namespace Shopping.ViewComponents.Layout.Catalog
{
    public class _CatalogList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
