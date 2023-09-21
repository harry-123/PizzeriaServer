using FluentValidation;
using PizzeriaServer.Dtos;

namespace PizzeriaServer.Validator
{
    public class OrderValidator: AbstractValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(o => o.DeliveryAddress).NotEmpty().WithMessage("DeliveryAddress must not be null or empty");
            RuleFor(o => o.OrderValue).GreaterThan(0).WithMessage("OrderValue cannot be zero");
            RuleFor(o => o.OrderItems).NotNull().Must(x => x.Count > 0).WithMessage("Order must contain one or more OrderItems");
            RuleFor(o => o.OrderItems).ForEach(oi => oi.SetValidator(new OrderItemValidator()));
            RuleFor(o => o).Must(o => o.OrderValue == o.OrderItems.Sum(x => x.NetPrice))
                .WithMessage("Incorrect order value")
                .WithName("OrderValue");
        }
    }
}
