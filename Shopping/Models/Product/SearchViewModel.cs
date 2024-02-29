namespace Shopping.Models.Product
{
    public class SearchViewModel
    {
        public string Search { get; set; }
        public string City { get; set; }
        public string Catalog { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string PriceStatus { get; set; }
        public string Date { get; set; }
    }
}
