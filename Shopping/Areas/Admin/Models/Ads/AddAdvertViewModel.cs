namespace Shopping.Areas.Admin.Models.Ads
{
    public class AddAdvertViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public IFormFile Img1 { get; set; }
        public IFormFile Img2 { get; set; }
        public IFormFile Img3 { get; set; }
        //public IFormFile Img4 { get; set; }
    }
}
