using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.API.Core.Entities;

namespace PizzaDelivery.API.Core.Interfaces
{
    public interface IPizzaRepository
    {
        public List<Pizza> obtenerMenuPizzas();
    }
}
