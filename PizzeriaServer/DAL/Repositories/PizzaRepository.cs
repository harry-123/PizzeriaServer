using AutoMapper;
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
    
    public List<Pizza> GetPizzas()
    {
        var pizzas = _dbContext.Pizzas
            .Include(x => x.Prices)
            .ThenInclude(x => x.PizzaSize)
            .ToList();
        return pizzas;
    }

    public List<Ingredient> GetPizzaIngredients()
    {
        var ingredients = _dbContext.Ingredients
            .Include(x => x.IngredientType)
            .Include(x => x.IngredientPrices)
            .ThenInclude(x => x.PizzaSize)
            .ToList();
        return ingredients;
    }
}