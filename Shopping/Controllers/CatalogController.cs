using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class CatalogController : Controller
    {
        public IActionResult Search(string Catalog)
        {
            Context context = new Context();
            
            var Product = from b in context.Products
                          select b;
            if (!string.IsNullOrEmpty(Catalog))
            {
                Product = Product.Where(b => b.Catalog.Contains(Catalog));
              ViewBag.v = Product.Where(x => x.Catalog.Contains(Catalog));
            }
          
            return View(Product);
        }
       
    }
}
