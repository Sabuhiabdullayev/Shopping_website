using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Areas.Admin.Models.OperatorContact;

namespace Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator,Writer")]
    public class MessageController : Controller
    {
        UserManager<AppUser> _userManager;
        IOperatorContactService _operatorContact;
        Context _context;

        public MessageController(UserManager<AppUser> userManager, IOperatorContactService operatorContact, Context context)
        {
            _userManager = userManager;
            _operatorContact = operatorContact;
            _context = context;
        }

        public IActionResult AllUsersList()
        {
            var value = _context.Users.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult IncomingMessages(int id)
        {
            var userId= _context.Users.FirstOrDefault(x=>x.Id==id);
            ViewBag.id = id;
            return View(userId);
        }
       [HttpGet]
       public PartialViewResult IncomingMessagesSend()
        {
            return PartialView();
        }
            [HttpPost]
        public async Task<IActionResult> IncomingMessagesSend(OperatorContactViewModel model)
        {
            var Values = await _userManager.FindByNameAsync(User.Identity.Name);
            OperatorContact p = new OperatorContact();
            p.AppUserId = Values.Id;
            p.ContactContent = model.ContactContent;
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.OwnerEmail = Values.Email;
            p.MessageOwnerId = model.MessageOwnerId;
            var id = model.MessageOwnerId;
            _operatorContact.TAdd(p);

            return RedirectToAction("IncomingMessages", "Message", new {area="Admin",id=id});
        }
        //public IActionResult MemberUser(int id)
        //{
        //    //var value = _userManager.Users.FirstOrDefault(x => x.Id == id);
        //    return View();
        //}
    }
}
