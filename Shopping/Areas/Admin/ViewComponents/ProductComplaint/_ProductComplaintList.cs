using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.ProductComplaint
{
    public class _ProductComplaintList:ViewComponent
    {
        IProductComplaintService _productComplaintService;

        public _ProductComplaintList(IProductComplaintService productComplaintService)
        {
            _productComplaintService = productComplaintService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _productComplaintService.TGetList();
            return View(value);
        }
    }
}
