namespace PizzeriaServer.Models;

public class IngredientType
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Navigation Properties
    public List<Ingredient> Ingredients { get; set; }
}