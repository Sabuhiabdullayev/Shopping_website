namespace Shopping.Areas.Member.Models
{
	public class ProductUploadModel
	{
        public string ProductName { get; set; }
        public string CarMake { get; set; }
        public string ProductModel { get; set; }
        public string CarEngineBox { get; set; }
        public string CarBody { get; set; }
        public string CarMileagekm { get; set; }
        public string VehicleFuelType { get; set; }
        public string Description { get; set; }
        public IFormFile Image1Url { get; set; }
        public IFormFile Image2Url { get; set; }
        public IFormFile Image3Url { get; set; }
        public IFormFile Image4Url { get; set; }
        public IFormFile Image5Url { get; set; }
        public IFormFile Image6Url { get; set; }
        public IFormFile Image7Url { get; set; }
        public IFormFile Image8Url { get; set; }
        public IFormFile Image9Url { get; set; }
        public IFormFile Image10Url { get; set; }
        public double Price { get; set; }
        public string PriceCurrency { get; set; }
        public string ProductOwnerName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string ProductNew { get; set; }
        public string Date { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string NumberOfRooms { get; set; }
        public string Fieldm2 { get; set; }
        public string PlaceOfResidence { get; set; }
        public string RentForSale { get; set; }
        public string BuildingType { get; set; }
        public string BuildingFloor { get; set; }
        public string LandForSale { get; set; }
        public string Delivery { get; set; }
        public string? CommentStatus { get; set; }
        public string? WorkArea { get; set; }
        public string? WorkSchedule { get; set; }
        public string? WorkPlace { get; set; }
        public string? Edaction { get; set; }
        public string? AnimalSpecies { get; set; }
        public string? FeedsforAnimals { get; set; }
        public string? Gender { get; set; }
        public string? ClothingType { get; set; }
        public string? Size { get; set; }
        public string? BusinessArea { get; set; }
        public string? TypeOfGoods { get; set; }

        public string Catalog { get; set; }
        public string Category1 { get; set; }

        public int AppUserId { get; set; }
        public int Category2Id { get; set; }

    }
}
