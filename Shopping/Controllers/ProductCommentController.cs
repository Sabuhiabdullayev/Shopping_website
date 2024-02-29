using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Shopping.Models.ProductCommentModel;

namespace Shopping.Controllers
{
    [AllowAnonymous]
    public class ProductCommentController : Controller
	{
        UserManager<AppUser> _userManager;
		IProductCommentService _productCommentService;

        public ProductCommentController(UserManager<AppUser> userManager, IProductCommentService productCommentService)
        {
            _userManager = userManager;
            _productCommentService = productCommentService;
        }

     
        [HttpGet]
        public IActionResult CommentList(int id)
        {
            var list = _productCommentService.TGetList().Where(x => x.ProductId == id).OrderByDescending(b => b.ProductCommentId);
            var jsonList = JsonConvert.SerializeObject(list);
            return Json(jsonList);
        }

        [HttpPost]
        public async Task<IActionResult> CommentAdd(ProductComment comment)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            comment.CommentOwnerName = user.Name;
          
           comment.ProductCommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            _productCommentService.TAdd(comment);
            var json = JsonConvert.SerializeObject(comment);
            return Json(json);
        }
        

     
    }
}
