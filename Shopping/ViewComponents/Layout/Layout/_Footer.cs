using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents
{
    public class _Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
