using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.API.Core.Entities;
using PizzaDelivery.API.Core.Interfaces;
using PizzaDelivery.API.Infrastructure.DataAccess;

namespace PizzaDelivery.API.Core.Services
{
    public class PizzaService : IPizzaRepository
    {
        private readonly DBContext _context;
        public PizzaService(DBContext context) 
        {
            _context= context;
            context.Database.EnsureCreated();  
        }
        public List<Pizza> obtenerMenuPizzas()
        {
            return _context.Pizza.ToList();
        }
    }
}
