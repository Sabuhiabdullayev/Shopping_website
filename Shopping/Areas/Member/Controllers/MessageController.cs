using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shopping.Areas.Member.Models.OperatorContact;

namespace Shopping.Areas.Member.Controllers
{
    [Area("Member")]
    //  [Route("Member/{controller=Home}/{action=Index}/{id?}")]
    
    public class MessageController : Controller
    {
        UserManager<AppUser> _userManager;
        IOperatorContactService _operatorContactService;
        Context _context;

        public MessageController(UserManager<AppUser> userManager, IOperatorContactService operatorContactService, Context context)
        {
            _userManager = userManager;
            _operatorContactService = operatorContactService;
            _context = context;
        }

       

      
        [HttpPost]
        public async Task<IActionResult> Send(OperatorContact p)
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = value.Id;
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
          
            p.OwnerEmail = value.Email;
            _operatorContactService.TAdd(p);
            var json = JsonConvert.SerializeObject(p);
            return Json(json);
        }
        [HttpGet]
        public async Task<IActionResult> MessageList(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userId = user.Id;
            var value = _operatorContactService.TGetList().Where(x => x.AppUserId == userId && x.MessageOwnerId==id || x.AppUserId == id && x.MessageOwnerId == userId || x.AppUserId == id || x.AppUserId == userId || x.MessageOwnerId == userId|| x.MessageOwnerId == id);
            var json = JsonConvert.SerializeObject(value);
            return Json(json);
        }

        [HttpGet]
        public IActionResult Chat()
        {
            return View();
        }
     
        [HttpGet]
        public async Task<IActionResult> ChatUsers()
        {
            var userid = await _userManager.FindByNameAsync(User.Identity.Name);
            var getlist = _context.Users.Where(x=>x.Id!=userid.Id).ToList();
            var json = JsonConvert.SerializeObject(getlist);
            return Json(json);
        }
        [HttpDelete]
        public IActionResult MessageDel(int id)
        {
            var messageid = _operatorContactService.TGetById(id);
            _operatorContactService.TDel(messageid);
            return Json(messageid);
        }
    }
}
