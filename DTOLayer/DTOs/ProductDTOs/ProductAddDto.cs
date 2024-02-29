using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.ProductDTOs
{
    public class ProductAddDto
    {
        public string ProductName { get; set; }
        public string CarMake { get; set; }
        public string ProductModel { get; set; }
        public string CarEngineBox { get; set; }
        public string CarBody { get; set; }
        public string CarMileagekm { get; set; }
        public string VehicleFuelType { get; set; }
        public string Description { get; set; }
        public FormFile Image1Url { get; set; }
        public FormFile Image2Url { get; set; }
        public FormFile Image3Url { get; set; }
        public FormFile Image4Url { get; set; }
        public FormFile Image5Url { get; set; }
        public FormFile Image6Url { get; set; }
        public FormFile Image7Url { get; set; }
        public FormFile Image8Url { get; set; }
        public FormFile Image9Url { get; set; }
        public FormFile Image10Url { get; set; }
        public string Price { get; set; }
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

        public string Catalog { get; set; }
        public string Category1 { get; set; }

        public int AppUserId { get; set; }
        public int Category2Id { get; set; }
    }
}
