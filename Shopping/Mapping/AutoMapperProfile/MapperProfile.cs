using AutoMapper;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ProductDTOs;
using EntityLayer.Concrete;

namespace Shopping.Mapping.AutoMapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
           
            CreateMap<SignUpDto, AppUser>();
            CreateMap<AppUser, SignUpDto>();

            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();
        }
    }
}
