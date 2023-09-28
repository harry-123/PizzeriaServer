using PizzeriaServer.Models;

namespace PizzeriaServer.DAL.IRepositories;

public interface IPizzaRepository
{
    Task<List<Pizza>> GetPizzas();
    Task<List<Ingredient>> GetPizzaIngredients();
}