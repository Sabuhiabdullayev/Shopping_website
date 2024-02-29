using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents
{
    public class VipUnapprovedProducts:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
