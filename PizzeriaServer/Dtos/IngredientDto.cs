namespace PizzeriaServer.Dtos;

public class IngredientDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public List<PriceDto> Prices { get; set; }
}