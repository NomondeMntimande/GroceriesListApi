using AutoMapper;
using GroceriesListApi.Models.Dtos;
using GroceriesListApi.Models.Entities;

namespace GroceriesListApi.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<GroceriesListDto, GroceriesList>()  
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<GroceriesList, GroceriesListDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
