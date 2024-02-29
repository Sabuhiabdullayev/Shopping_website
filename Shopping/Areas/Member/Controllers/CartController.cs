using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shopping.Areas.Member.Models.Cart;

namespace Shopping.Areas.Member.Controllers
{
    [Area("Member")]

    public class CartController : Controller
    {
        ICartService _cartService;
        UserManager<AppUser> _userManager;
        Context _context;
        public CartController(ICartService cartService, UserManager<AppUser> userManager, Context context)
        {
            _cartService = cartService;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Selected()
        {
            return View();
        }
        public IActionResult SelectedCart()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(CartProductAddViewModel model)
        {
            var UserId = await _userManager.FindByNameAsync(User.Identity.Name);
                    Cart cart = new Cart()
                    {
                        AppUserId = UserId.Id,
                        ProductId = model.ProductId
                    };
                    _cartService.TAdd(cart);

                    return RedirectToAction("Selected", "Cart", new { area = "Member" });
             
        }
        [HttpPost]
        public async Task<IActionResult> CartAdd(Cart c)
        {
            var UserId = await _userManager.FindByNameAsync(User.Identity.Name);
            c.AppUserId = UserId.Id;
            _cartService.TAdd(c);
            var json = JsonConvert.SerializeObject(c);

            return Json(json);
        }
      
        [HttpPost]
        public IActionResult MyCartDelete(int id)
		{
            var delid = _cartService.TGetById(id);
            _cartService.TDel(delid);
       
            return Json(delid);
		}
        public async Task<IActionResult> CartList(int id)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var listCart = _cartService.TGetList().Where(x => x.ProductId == id && x.AppUserId == user.Id);
            var json = JsonConvert.SerializeObject(listCart);
            return Json(json);
        }
        [HttpPost]
        public async Task<IActionResult> AllDelete(int count)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var allcount=count+10;
                IEnumerable<Cart> cart = _context.Carts.Take(allcount).Where(x=>x.AppUserId==user.Id).ToList();
_context.Carts.RemoveRange(cart);
            _context.SaveChanges();
       return RedirectToAction("Selected", "Cart", new { area = "Member" });
        }
        [HttpDelete]
        public  async Task<IActionResult> ProductDeSelect(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var getId = _cartService.TGetById(id);
            _cartService.TDel(getId);
            var json = JsonConvert.SerializeObject(getId);
            return Json(json);
        }
        public IActionResult DeSelectCartList(int id)
        {
           
            var listCart = _cartService.TGetList().Where(x => x.CartId == id);
            var json = JsonConvert.SerializeObject(listCart);
            return Json(json);
        }
        public async Task<IActionResult> MyAllCartList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var listCart = _cartService.TGetList().Where(x => x.AppUserId == user.Id);
            var json = JsonConvert.SerializeObject(listCart);
            return Json(json);
        }
    }
}
