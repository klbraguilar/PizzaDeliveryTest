using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.API.Core.Entities;
using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Web
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly IPizzaRepository _pizzaRepository;
        public PizzasController(IPizzaRepository pizzaRepository) 
        {
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet]
        public List<Pizza> obtenerMenu()
        {
            return _pizzaRepository.obtenerMenuPizzas();
        } 
    }
}
