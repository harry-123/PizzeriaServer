using Microsoft.EntityFrameworkCore;
using PizzeriaServer.DAL.IRepositories;
using PizzeriaServer.DbContext;
using PizzeriaServer.Models;

namespace PizzeriaServer.DAL.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrdersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int PlaceOrder(Order order)
        {
            order.OrderItems.ForEach(oi =>
            {
                var oiIndex = 0;
                var pizza = _dbContext.Pizzas.Where(p => p.Id == oi.Pizza.Id)
                                .Include(p => p.Prices)
                                .ThenInclude(x => x.PizzaSize)
                                .SingleOrDefault();
                if (pizza is null || !oi.Pizza.Name.Equals(pizza.Name))
                {
                    throw new InvalidOrderException($"orderItem[{oiIndex}]", "Invalid ItemId or name");
                }
                oi.Pizza = pizza;
                var pizzaPrice = pizza.Prices.SingleOrDefault(x => x.PizzaSize.Name.Equals(oi.PizzaSize.Name));
                if (pizzaPrice is null)
                {
                    throw new InvalidOrderException($"orderItem[{oiIndex}].size", "Invalid Item Size");
                }
                oi.PizzaSize = pizzaPrice.PizzaSize;

                if (oi.OrderItemIngredients.Count == 0 && oi.NetPrice != pizzaPrice.Price * oi.Quantity)
                {
                    throw new InvalidOrderException($"orderItem[{oiIndex}].netPrice", "Invalid NetPrice");
                }
                
                if (oi.OrderItemIngredients.Count > 0) 
                {
                    var customizedPizzaPrice = pizzaPrice.Price;
                    oi.OrderItemIngredients.ForEach(i =>
                    {
                        var ingredient = _dbContext.Ingredients.Where(x => x.Id == i.IngredientId)
                                            .Include(x => x.IngredientPrices)
                                            .ThenInclude(x => x.PizzaSize)
                                            .SingleOrDefault();
                        var ingredientPrice = ingredient?.IngredientPrices
                                                .SingleOrDefault(x => x.PizzaSize.Name.Equals(oi.PizzaSize.Name));
                        if (ingredient is null || ingredientPrice is null)
                        {
                            throw new InvalidOrderException($"orderItem[{oiIndex}].ingredients", "Invalid ingredients");
                        }
                        customizedPizzaPrice += ingredientPrice.Price;
                        i.Ingredient = ingredient;
                    });
                    if (customizedPizzaPrice != oi.NetPrice)
                    {
                        throw new InvalidOrderException($"orderItem[{oiIndex}].netPrice", "Invalid NetPrice");
                    }
                }
                
            });
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order.Id;
        }
    }
}
