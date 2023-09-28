using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzeriaServer.DAL.IRepositories;
using PizzeriaServer.Dtos;
using PizzeriaServer.Models;

namespace PizzeriaServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;
    private readonly IPizzaRepository _pizzaRepository;
    private readonly IMapper _mapper;


    public PizzaController(ILogger<PizzaController> logger, IPizzaRepository pizzaRepository, IMapper mapper)
    {
        _logger = logger;
        _pizzaRepository = pizzaRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetPizzas()
    {
        try
        {
            var pizzas = await _pizzaRepository.GetPizzas();
            return Ok(pizzas.Select(p => _mapper.Map<Pizza, PizzaDto>(p)).ToList());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception while getting Pizzas");
            return StatusCode(500);
        }
    }

    [HttpGet("Ingredients")]
    public async Task<IActionResult> GetPizzaIngredients()
    {
        try
        {
            var ingredients = await _pizzaRepository.GetPizzaIngredients();
            return Ok(ingredients.Select(i => _mapper.Map<Ingredient, IngredientDto>(i)).ToList());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception while getting Pizza Ingredients");
            return StatusCode(500);
        }
    }


}