using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents
{
    public class VipExpectedProducts:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
