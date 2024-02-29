using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping.Models;

namespace Shopping.ViewComponents
{
    public class _Topbar:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
