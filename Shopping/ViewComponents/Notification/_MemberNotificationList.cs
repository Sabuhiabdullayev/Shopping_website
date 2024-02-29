using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.ViewComponents.Notification
{
    public class _MemberNotificationList : ViewComponent
    {
        UserManager<AppUser> _userManager;
        INotificationService _notificationService;

        public _MemberNotificationList(UserManager<AppUser> userManager, INotificationService notificationService)
        {
            _userManager = userManager;
            _notificationService = notificationService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var GetList = _notificationService.TGetFilterListNotification(user.Id).OrderByDescending(x=>x.NotificationId).ToList();
            return View(GetList);
        }
    }
}
