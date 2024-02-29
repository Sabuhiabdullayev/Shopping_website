using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class ProductLikeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IProductLikeService _productLikeService;
        private readonly Context _context;

        public ProductLikeController(UserManager<AppUser> userManager, IProductLikeService productLikeService, Context context)
        {
            _userManager = userManager;
            _productLikeService = productLikeService;
            _context = context;
        }

        public IActionResult LikeList(int id)
        {
            var listCart = _productLikeService.TGetList().Where(x => x.ProductId == id);
            var json = JsonConvert.SerializeObject(listCart);
            return Json(json);
        }
      
        [HttpPost]
        public async Task<IActionResult> LikeAdd(ProductLike productLike)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            productLike.MemberId = user.Id;
            productLike.NumberOfLikes = productLike.NumberOfLikes;
            _productLikeService.TAdd(productLike);
            var json = JsonConvert.SerializeObject(productLike);
            return Json(json);
        }

        public IActionResult ProductLikeCount(int id)
        {
           var CountList= _productLikeService.TGetList().Where(x=>x.ProductId==id).Count();
            var json = JsonConvert.SerializeObject(CountList);
            return Json(json);
        }

        //public async Task<IActionResult> AllDelete()
        //{
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    IEnumerable<ProductLike> like = _context.ProductLikes.Take(1000).ToList();
        //    _context.ProductLikes.RemoveRange(like);
        //    _context.SaveChanges();
        //    return RedirectToAction("AllProductPage", "Home");
        //}
      
    }
}
