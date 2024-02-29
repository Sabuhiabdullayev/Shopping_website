using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents
{
    public class VipVerifiedProducts:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
