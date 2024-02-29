using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Contact
{
    public class _OperatorMessageList:ViewComponent
    {
        IOperatorContactService _operatorContactService;

        public _OperatorMessageList(IOperatorContactService operatorContactService)
        {
            _operatorContactService = operatorContactService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var valueList = _operatorContactService.TGetMemberIncludeList().Where(x => x.MessageOwnerId == id || x.AppUserId == id);
            ViewBag.MemberId = id;
            return View(valueList);
        }
    }
}
