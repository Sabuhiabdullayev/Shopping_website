using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Catalog
    {
        [Key]
        public int CatalogId { get; set; }
        public string CatalogName { get; set; }

        public List<Category2>? Category2s { get; set; }
    }
}
