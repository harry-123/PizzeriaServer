namespace PizzeriaServer.Dtos;

public class PizzaDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ThumbnailPath { get; set; }
    public List<PriceDto> Prices { get; set; }
}