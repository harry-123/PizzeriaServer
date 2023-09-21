namespace PizzeriaServer.Models;

public class IngredientPrice
{
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public int SizeId { get; set; }
    public int Price { get; set; }
    
    // Navigation Properties
    public Ingredient Ingredient { get; set; }
    public PizzaSize PizzaSize { get; set; }
}