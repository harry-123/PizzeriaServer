namespace PizzeriaServer.Models;

public class PizzaPrice
{
    public int Id { get; set; }
    public int PizzaId { get; set; }
    public int SizeId { get; set; }
    public int Price { get; set; }
    
    // Navigation Properties
    public Pizza Pizza { get; set; }
    public PizzaSize PizzaSize { get; set; }
}