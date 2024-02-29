using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Ads
{
    public class _AdsGetList:ViewComponent
    {
        IAdsDal _adsDal;

        public _AdsGetList(IAdsDal adsDal)
        {
            _adsDal = adsDal;
        }

        public IViewComponentResult Invoke()
        {
            var value = _adsDal.GetList();
            return View(value);
        }
    }
}
