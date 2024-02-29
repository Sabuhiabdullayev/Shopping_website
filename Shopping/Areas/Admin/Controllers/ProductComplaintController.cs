using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ProductComplaintController : Controller
    {
        IProductComplaintService _productComplaintService;

        public ProductComplaintController(IProductComplaintService productComplaintService)
        {
            _productComplaintService = productComplaintService;
        }

        public IActionResult ComplaintList()
        { 
            return View();
        }

        public IActionResult ComplaintRemove(int id)
        {
            var GetById = _productComplaintService.TGetById(id);
            _productComplaintService.TDel(GetById);
            return RedirectToAction("ComplaintList", "ProductComplaint", new {Area="Admin"});
        }
        public IActionResult ComplaintLong(int id)
        {
            var GetId = _productComplaintService.TGetById(id);
            return View(GetId);
        }
    }
}
