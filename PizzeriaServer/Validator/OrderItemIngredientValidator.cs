using FluentValidation;
using PizzeriaServer.Dtos;

namespace PizzeriaServer.Validator
{
    public class OrderItemIngredientValidator : AbstractValidator<OrderItemIngredientDto>
    {
        public OrderItemIngredientValidator()
        {
            RuleFor(x => x.IngredientId).NotEmpty().WithMessage("IngredientId must not be empty");
        }
    }
}
