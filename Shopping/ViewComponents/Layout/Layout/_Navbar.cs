using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shopping.ViewComponents       
{
    public class _Navbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.City = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Agcabədi"},
                new SelectListItem{ Text="Ağdam"},
                new SelectListItem{ Text="Ağdaş"},
                new SelectListItem{ Text="Ağdərə"},
                new SelectListItem{ Text="Ağstafa"},
                new SelectListItem{ Text="Ağsu"},
                new SelectListItem{Text="Astara"},
                new SelectListItem{ Text="Bakı"},
                new SelectListItem{ Text="Balakən"},
                new SelectListItem{Text="Beylaqan"},
                new SelectListItem{ Text="Bərdə"},
                new SelectListItem{Text="Biləsuvar"},
                new SelectListItem{Text="Cəbrayıl"},
                new SelectListItem{ Text="Cəlilabad"},
                new SelectListItem{ Text="Culfa"},
                new SelectListItem{Text="Daşkəsən"},
                new SelectListItem{ Text="Füzuli"},
                new SelectListItem{Text="Gədəbəy"},
                new SelectListItem{ Text="Gəncə"},
                new SelectListItem{ Text="Goranboy"},
                new SelectListItem{Text="Göyçay"},
                new SelectListItem{ Text="Göygöl"},
                new SelectListItem{ Text="Göytəpə"},
                new SelectListItem{ Text="Hacıqabul"},
                new SelectListItem{ Text="Horadiz"},
                new SelectListItem{ Text="İmişli"},
                new SelectListItem{Text="İsmayıllı"},
                new SelectListItem{Text="Kəlbəcər"},
                new SelectListItem{Text="Kürdəmir"},
                new SelectListItem{Text="Laçın"},
                new SelectListItem{Text="Lerik"},
                new SelectListItem{Text="Lənkəran"},
                new SelectListItem{Text="Massallı"},
                new SelectListItem{Text="Mingəçəvir"},
                new SelectListItem{Text="Nabran"},
                new SelectListItem{Text="Naftalan"},
                new SelectListItem{Text="Naxçəvan"},
                new SelectListItem{Text="Neftçala"},
                new SelectListItem{Text="Oğuz"},
                new SelectListItem{Text="Ordubad"},
                new SelectListItem{Text="Qax"},
                new SelectListItem{Text="Qazax"},
                new SelectListItem{Text="Qəbələ"},
                new SelectListItem{Text="Qobustan"},
                new SelectListItem{Text="Quba"},
                new SelectListItem{Text="Qubadlı"},
                new SelectListItem{Text="Qusar"},
                new SelectListItem{Text="Saatlı"},
                new SelectListItem{Text="Sabirabad"},
                new SelectListItem{Text="Şabran"},
                new SelectListItem{Text="Şahbuz"},
                new SelectListItem{Text="Salyan"},
                new SelectListItem{Text="Şamaxı"},
                new SelectListItem{ Text="Samux"},
                new SelectListItem{ Text="Şəki"},
                new SelectListItem{ Text="Şəmkir"},
                new SelectListItem{ Text="Şərur"},
                new SelectListItem{ Text="Şirvan"},
                new SelectListItem{ Text="Siyəzən"},
                new SelectListItem{ Text="Sumqayıt"},
                new SelectListItem{ Text="Şuşa"},
                new SelectListItem{ Text="Tərtər"},
                new SelectListItem{ Text="Tovuz"},
                new SelectListItem{ Text="Ucar"},
                new SelectListItem{ Text="Xaçmaz"},
                new SelectListItem{ Text="Xankəndi"},
                new SelectListItem{ Text="Xırdalan"},
                new SelectListItem{ Text="Xızı"},
                new SelectListItem{ Text="Xocalı"},
                new SelectListItem{ Text="Xocavənd"},
                new SelectListItem{ Text="Xudat"},
                new SelectListItem{ Text="Yardımlı"},
                new SelectListItem{ Text="Yevlax"},
                new SelectListItem{ Text="Zaqatala"},
                new SelectListItem{ Text="Zəngilan"},
                new SelectListItem{ Text="Zərdab"}

            };
            ViewBag.Catalog = new List<SelectListItem>() 
            {
                new SelectListItem{Text="Elektronika" },
                new SelectListItem{Text="Daşınmaz-Əmlak" },
                new SelectListItem{Text="Nəqliyyat" },
                new SelectListItem{Text="Ev və Bağ üçün" },
                new SelectListItem{Text="Biznes və Xidmətlər" },
                new SelectListItem{Text="Şəxsi Əşyalar" },
                new SelectListItem{Text="Hobbi və Asudə" },
                new SelectListItem{Text="Heyvanlar və Yemləri" },
                new SelectListItem{Text="İş Elanları" },
            };

            return View();
        }
    }
}
