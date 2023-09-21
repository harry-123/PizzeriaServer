using AutoMapper;
using PizzeriaServer.Dtos;
using PizzeriaServer.Models;

namespace PizzeriaServer.MappingProfiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<PizzaPrice, PriceDto>()
            .ForMember(dest => dest.Price, opt => opt.MapFrom(source => source.Price))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(source => source.PizzaSize.Name));
        CreateMap<Pizza, PizzaDto>();
        CreateMap<IngredientPrice, PriceDto>()
            .ForMember(dest => dest.Price, opt => opt.MapFrom(source => source.Price))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(source => source.PizzaSize.Name));
        CreateMap<Ingredient, IngredientDto>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(x => x.IngredientType.Name))
            .ForMember(dest => dest.Prices, opt => opt.MapFrom(source => source.IngredientPrices));
    }
}