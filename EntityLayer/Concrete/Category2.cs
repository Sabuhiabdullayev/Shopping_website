using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category2
    {
     

        [Key]
        public int Category2Id { get; set; }
        public string Category2Name { get; set; }

        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public int CatalogId { get; set; }
        public Catalog Catalog { get; set; }
    }
}
