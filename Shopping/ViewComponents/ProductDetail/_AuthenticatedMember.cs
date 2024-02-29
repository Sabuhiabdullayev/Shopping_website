using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.ProductDetail
{
    public class _AuthenticatedMember:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AuthenticatedMember(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
         var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.MemberId = user.Id;
            return View();
        }
    }
}
