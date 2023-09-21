using FluentValidation;
using PizzeriaServer.Dtos;

namespace PizzeriaServer.Validator
{
    public class OrderItemValidator : AbstractValidator<OrderItemDto>
    {
        public OrderItemValidator() 
        {
            RuleFor(o => o.ItemId).GreaterThan(0).WithMessage("OrderValue cannot be zero");
            RuleFor(o => o.Name).NotEmpty().WithMessage("Name cannot be null and empty");
            RuleFor(o => o.Quantity).GreaterThan(0).WithMessage("Quantity cannot be zero");
            RuleFor(o => o.Size).NotEmpty().WithMessage("Size cannot be null and empty");
            RuleFor(o => o.NetPrice).GreaterThan(0).WithMessage("NetPrice cannot be zero");
            RuleFor(o => o.Ingredients).ForEach(oi => oi.SetValidator(new OrderItemIngredientValidator()));
            When(o => o.Ingredients.Count > 0, () =>
            {
                RuleFor(o => o.Quantity).Equal(1).WithMessage("Cannot add one than one customized pizzas");
            });

        }
    }
}
