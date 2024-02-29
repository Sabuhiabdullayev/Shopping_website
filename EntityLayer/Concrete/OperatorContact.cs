using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OperatorContact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactContent { get; set; }
        public string OwnerEmail { get; set; }
        public DateTime ContactDate { get; set; }
        public int MessageOwnerId { get; set; }


        public int AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser? AppUsers { get; set; }
    }
}
