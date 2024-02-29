using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
       
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? CarMake { get; set; }
        public string? ProductModel { get; set; }
        public string? CarEngineBox { get; set; }
        public string? CarBody { get; set; }
        public string? CarMileagekm { get; set; }
        public string? VehicleFuelType { get; set; }
        public string? Description { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }
        public string? Image6 { get; set; }
        public string? Image7 { get; set; }
        public string? Image8 { get; set; }
        public string? Image9 { get; set; }
        public string? Image10 { get; set; }
        public double Price { get; set; }
        public string? PriceCurrency { get; set; }
        public string? Vip { get; set; }
        public string? Premium { get; set; }
        public string City { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? ProductNew { get; set; }
        public DateTime Date { get; set; }
        public string? Year { get; set; }
        public string? Color { get; set; }
        public string? NumberOfRooms { get; set; }
        public string? Fieldm2 { get; set; }
        public string? PlaceOfResidence { get; set; }
        public string? RentForSale { get; set; }
        public string? BuildingType { get; set; }
        public string? BuildingFloor { get; set; }
        public string? LandForSale { get; set; }
        public string? Delivery { get; set; }
        public string? ProductStatus { get; set; }
        public string? MyProductStatus { get; set; }
        public string? ShopProductStatus { get; set; }
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
        public string? TypeOfGoods{ get; set; }
        public string? ProductOwnerName { get; set; }

        public string? Catalog { get; set; }
        public string? Category1 { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int Category2Id { get; set; }
        public Category2? Category2 { get; set; }

        public List<Cart> Cart { get; set; }

        public List<ProductComment>? ProductComment { get; set; }

        public List<ProductComplaint>? ProductComplaints { get; set; }
        public List<ProductLike> ProductLikes { get; set; }
        public List<ProductView> productViews { get; set; }
    }
}
