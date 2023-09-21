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
            .ForMember(dest => dest.Type, opt => opt.MapFrom(source => source.IngredientType.Name))
            .ForMember(dest => dest.Prices, opt => opt.MapFrom(source => source.IngredientPrices));
        CreateMap<OrderDto, Order>()
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(source => source.OrderItems));
        CreateMap<OrderItemDto, OrderItem>()
            .ForMember(dest => dest.Pizza, opt => opt.MapFrom(source => new Pizza { Id = source.ItemId, Name = source.Name } ))
            .ForMember(dest => dest.PizzaSize, opt => opt.MapFrom(source => new PizzaSize { Name = source.Size }))
            .ForMember(dest => dest.OrderItemIngredients, opt => opt.MapFrom(source => source.Ingredients));
        CreateMap<OrderItemIngredientDto, OrderItemIngredient>()
            .ForMember(dest => dest.IngredientId, opt => opt.MapFrom(source => source.IngredientId));



    }
}