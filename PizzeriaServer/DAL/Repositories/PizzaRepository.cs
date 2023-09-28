using Microsoft.EntityFrameworkCore;
using PizzeriaServer.DAL.IRepositories;
using PizzeriaServer.DbContext;
using PizzeriaServer.Models;

namespace PizzeriaServer.DAL.Repositories;

public class PizzaRepository : IPizzaRepository
{
    private readonly ApplicationDbContext _dbContext;
    
    public PizzaRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Pizza>> GetPizzas()
    {
        var pizzas = await _dbContext.Pizzas
            .Include(x => x.Prices)
            .ThenInclude(x => x.PizzaSize)
            .ToListAsync();
        return pizzas;
    }

    public async Task<List<Ingredient>> GetPizzaIngredients()
    {
        var ingredients = await _dbContext.Ingredients
            .Include(x => x.IngredientType)
            .Include(x => x.IngredientPrices)
            .ThenInclude(x => x.PizzaSize)
            .ToListAsync();
        return ingredients;
    }
}