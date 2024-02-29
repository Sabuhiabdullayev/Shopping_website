using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.Models.Product
{
	public class ProductSearchViewModel
	{
		
		public string? City { get; set; }
		public string? ProductName { get; set; }
        public double PriceMin { get; set; }
        public double PriceMax { get; set; }
        public string? Status { get; set; }
        public string? VipStatus { get; set; }
        public string? PremiumStatus { get; set; }
   
        public DateTime DateMin { get; set; }
        [BindProperty]
        public DateTime DateMax { get; set; }
    }
}
