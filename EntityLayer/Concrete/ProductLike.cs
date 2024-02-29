using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductLike
    {
        [Key]
        public int LikeId { get; set; }
        public int NumberOfLikes { get; set; }

        public int AppUserId { get; set; }

        public int MemberId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
