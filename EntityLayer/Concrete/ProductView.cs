using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductView
    {
        [Key]
        public int ViewId { get; set; }
        public int NumberOfProductViews { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
