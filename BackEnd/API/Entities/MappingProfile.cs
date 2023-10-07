using AutoMapper;

namespace API.Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Order, OrderDto>()
            //    .ForMember(dest => dest.RestaurantName, opt => opt.MapFrom(src => src.Restaurant.RestaurantName))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Restaurant.Description));

            //CreateMap<Product, ProductDto>()
            //  .ForMember(dest => dest.RestaurantName, opt => opt.MapFrom(src => src.Restaurant.RestaurantName))
            //  .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ProductImages.FirstOrDefault().ImageUrl));
        }
    }
}
