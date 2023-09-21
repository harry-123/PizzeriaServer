namespace PizzeriaServer.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IngredientTypeId { get; set; }
    
    // Navigation Properties
    public IngredientType IngredientType { get; set; }
    public List<IngredientPrice> IngredientPrices { get; set; }
    public List<OrderItemIngredient> OrderItemIngredients { get; set; }
}