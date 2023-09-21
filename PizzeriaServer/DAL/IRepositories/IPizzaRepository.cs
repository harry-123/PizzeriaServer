using PizzeriaServer.Models;

namespace PizzeriaServer.DAL.IRepositories;

public interface IPizzaRepository
{
    List<Pizza> GetPizzas();
    List<Ingredient> GetPizzaIngredients();
}