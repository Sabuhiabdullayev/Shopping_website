using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.OperatorContact
{
    public class _ContactMemberList:ViewComponent
    {
        UserManager<AppUser> _userManager;
        IOperatorContactService _operatorContactService;

        public _ContactMemberList(UserManager<AppUser> userManager, IOperatorContactService operatorContactService)
        {
            _userManager = userManager;
            _operatorContactService = operatorContactService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userid = await _userManager.FindByNameAsync(User.Identity.Name);
            var getlist = _userManager.Users.Where(x => x.Id != userid.Id).ToList();
            return View(getlist);
        }
    }
}
