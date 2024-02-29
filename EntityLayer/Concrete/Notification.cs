using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Img { get; set; }
        public bool NotificationStatus { get; set; }
        public int MemberId { get; set; }
        public bool Like { get; set; }
        public bool Comment { get; set; }
        public bool MemberView { get; set; }


        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
