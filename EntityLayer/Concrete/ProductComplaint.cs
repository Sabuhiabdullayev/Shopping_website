using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductComplaint
    {
        [Key]
        public int ComplaintId { get; set; }
        public string? Title { get; set; }
        public string? CauseOfComplaint { get; set; }
        public string? Content { get; set; }
        public string? ComplaintPhoto { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string? NameSurname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
