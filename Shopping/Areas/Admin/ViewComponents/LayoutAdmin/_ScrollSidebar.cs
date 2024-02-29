using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.LayoutAdmin
{
    public class _ScrollSidebar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
