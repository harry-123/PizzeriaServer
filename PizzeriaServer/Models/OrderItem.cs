namespace PizzeriaServer.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int PizzaId { get; set; }
    public int SizeId { get; set; }
    public int OrderId { get; set; }
    
    // Navigation Properties
    public Pizza Pizza { get; set; }
    public PizzaSize PizzaSize { get; set; }
    public Order Order { get; set; }
    public List<OrderItemIngredient> OrderItemIngredients { get; set; }
}