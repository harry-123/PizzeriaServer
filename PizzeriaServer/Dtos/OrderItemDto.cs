namespace PizzeriaServer.Dtos;

public class OrderItemDto
{
    public int ItemId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Size { get; set; }
    public int NetPrice { get; set; }
    public List<OrderItemIngredientDto> Ingredients { get; set; }
}