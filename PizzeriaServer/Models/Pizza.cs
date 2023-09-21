namespace PizzeriaServer.Models;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ThumbnailPath { get; set; }
    
    // Navigation Properties
    public List<PizzaPrice> Prices { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}