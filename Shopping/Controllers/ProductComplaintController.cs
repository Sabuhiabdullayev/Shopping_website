using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models.ProductComplaintModel;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class ProductComplaintController : Controller
    {
        IProductComplaintService _productComplaintService;

        public ProductComplaintController(IProductComplaintService productComplaintService)
        {
            _productComplaintService = productComplaintService;
        }
       

        [HttpGet]
        public PartialViewResult ProductComplaintSend()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult ProductComplaintSend(ProductComplaintViewModel model)
        {
            ProductComplaint p = new ProductComplaint();
            if (model.ComplaintPhoto != null)
            {
                var Extension = Path.GetExtension(model.ComplaintPhoto.FileName);
                var newImageName = Guid.NewGuid() + Extension;
                var Location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Shopping/ProductComplaintImg/" + newImageName);
                var Stream = new FileStream(Location, FileMode.Create);
                model.ComplaintPhoto.CopyTo(Stream);
                p.ComplaintPhoto = newImageName;
            }
            else
            {
                p.ComplaintPhoto = "null";
            }
            var Productid = model.ComplaintProductId;
            p.ComplaintDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.NameSurname = model.NameSurname;
            p.Phone = model.Phone;
            p.ProductId = Productid;
            p.Title = model.Title;
            p.Email = model.Email;
            p.Content = model.Content;
            p.CauseOfComplaint = model.CauseOfComplaint;
            _productComplaintService.TAdd(p);
        
            return RedirectToAction("Detail", "Product", new {@id= Productid});
        }
    }
}
