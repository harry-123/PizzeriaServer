namespace PizzeriaServer.Dtos;

public class OrderDto
{
    public string DeliveryAddress { get; set; }
    public int OrderValue { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
}