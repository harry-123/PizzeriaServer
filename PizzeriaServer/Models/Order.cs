namespace PizzeriaServer.Models;

public class Order
{
    public int Id { get; set; }
    public string DeliveryAddress { get; set; }
    public int OrderValue { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}