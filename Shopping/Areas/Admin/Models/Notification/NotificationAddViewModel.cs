namespace Shopping.Areas.Admin.Models.Notification
{
    public class NotificationAddViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Img { get; set; }
        public int MemberId { get; set; }
    }
}
