using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Member.ViewComponents.Notification
{
    public class _MyNotificationAllList:ViewComponent
    {
       private readonly UserManager<AppUser> _userManager;
       private readonly  INotificationService _notificationService;

        public _MyNotificationAllList(UserManager<AppUser> userManager, INotificationService notificationService)
        {
            _userManager = userManager;
            _notificationService = notificationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var list = _notificationService.TGetFilterListNotification(user.Id).OrderByDescending(x => x.NotificationId).ToList();
            return View(list);
        }
    }
}
