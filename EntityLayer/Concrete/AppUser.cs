using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
       
        public string? SurName { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? BigImageUrl { get; set; }
        public string? Genger { get; set; }
        public string? confirmed { get; set; }
        public string? MemberMessage { get; set; }
        public string? ShopStatus { get; set; }
        public string? ShopName { get; set; }
        public string? ShopDescription { get; set; }
        public DateTime ShopDate { get; set; }
        public string? ShopSmallImage { get; set; }
        public string? ShopBigImage { get; set; }
        public string? ShopPhone { get; set; }
        public string? ShopConfirmed { get; set; }
        public string? Dateofbirth { get; set; }
        public DateTime AppUserDate{ get; set; }
        public string? MemberStatus { get; set; }
		public string? MemberDescription { get; set; }
		public string? MemberSpecialWebSite { get; set; }
		public string? MemberFacebookWebSite { get; set; }
		public string? MemberInstagramWebSite { get; set; }
		public string? MemberTiktokWebSite { get; set; }
        public string? ShopMemberSpecialWebSite { get; set; }
		public string? ShopMemberFacebookWebSite { get; set; }
		public string? ShopMemberInstagramWebSite { get; set; }
		public string? ShopMemberTiktokWebSite { get; set; }

		public List<Product>? Products { get; set; }
		public List<Cart> Carts { get; set; }
        public List<Notification>? Notifications { get; set; }

       
        public List<OperatorContact>? OperatorContacts { get; set; }

   

    }
}
