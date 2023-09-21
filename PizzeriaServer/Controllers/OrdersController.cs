using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PizzeriaServer.DAL.IRepositories;
using PizzeriaServer.Dtos;
using PizzeriaServer.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzeriaServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<OrderDto> _validator;

        public OrdersController(
            ILogger<OrdersController> logger,
            IOrdersRepository ordersRepository,
            IMapper mapper,
            IValidator<OrderDto> validator)
        {
            _logger = logger;
            _ordersRepository = ordersRepository;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(OrderDto orderDto)
        {
            try
            {
                var result = await _validator.ValidateAsync(orderDto);
                if (result.IsValid)
                {
                    var order = _mapper.Map<OrderDto, Order>(orderDto);
                    var orderId = _ordersRepository.PlaceOrder(order);
                    return Created(orderId.ToString(), null);
                }
                var errors = result.Errors.Select(x => new { x.PropertyName, x.ErrorMessage }).ToList();
                return BadRequest(new { Errors = errors, Message = "Model Validation Failed" });
            }
            catch(InvalidOrderException ex)
            {
                var error = new { ex.PropertyName, ErrorMessage = ex.Message };
                return BadRequest(new { Errors = new List<object> { error }, Message = "Model Validation Failed" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred while placing order.");
                return StatusCode(500);
            }
        }
    }
}
