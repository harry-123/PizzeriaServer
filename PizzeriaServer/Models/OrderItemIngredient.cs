namespace PizzeriaServer.Models;

public class OrderItemIngredient
{
    public int Id { get; set; }
    public int OrderItemId { get; set; }
    public int IngredientId { get; set; }
    
    // Navigation Properties
    public OrderItem OrderItem { get; set; }
    public Ingredient Ingredient { get; set; }
    
}