namespace Shopping.Models.ProductComplaintModel
{
    public class ProductComplaintViewModel
    {
        public string Title { get; set; }
        public string CauseOfComplaint { get; set; }
        public string Content { get; set; }
        public IFormFile ComplaintPhoto { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int ComplaintProductId { get; set; }
    }
}
