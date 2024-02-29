using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents
{
    public class _NavbarAds:ViewComponent
    {
        IAdsService _adsService;

        public _NavbarAds(IAdsService adsService)
        {
            _adsService = adsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _adsService.TGetList();
            return View(value);
        }
    }
}
