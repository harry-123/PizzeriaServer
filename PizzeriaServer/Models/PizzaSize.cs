namespace PizzeriaServer.Models;

public class PizzaSize
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Navigation Properties
    public List<PizzaPrice> PizzaPrices { get; set; }
    public List<IngredientPrice> IngredientPrices { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}