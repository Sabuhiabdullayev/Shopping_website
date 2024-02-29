namespace Shopping.Areas.Member.Models
{
    public class ShopViewModel
    {
        public string ShopName { get; set; }
        public string ShopDescription { get; set; }
        public string ShopPhone { get; set; }
        public DateTime ShopDate { get; set; }
        public IFormFile ShopSmallImage { get; set; }
        public IFormFile ShopBigImage { get; set; }
    }
}
