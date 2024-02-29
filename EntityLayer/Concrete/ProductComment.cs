using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentId { get; set; }
        public string? CommentOwnerName { get; set; }
        public string? ProductCommentContent { get; set; }
        public string? ProductCommentEmail { get; set; }
        public DateTime ProductCommentDate { get; set; }
  

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Products { get; set; }

      



    }
}
