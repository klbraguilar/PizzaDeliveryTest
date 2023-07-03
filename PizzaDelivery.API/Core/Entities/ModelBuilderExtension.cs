using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace PizzaDelivery.API.Core.Entities
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza {Ingredientes = new List<string>() {"Queso","Salsa", "Peperoni","Choclo" },Nombre="Tradicional", Precio=40 },
                new Pizza {Ingredientes = new List<string>() {"Queso","Salsa", "Champignon","Carne" },Nombre="Primavera", Precio=40 },
                new Pizza { Ingredientes = new List<string>() { "Queso", "Salsa", "Jamon", "Pimientos" }, Nombre = "Primavera", Precio = 40 },
                new Pizza { Ingredientes = new List<string>() { "Queso", "Salsa", "Carne", "Mozzarella" }, Nombre = "Cheese Burger", Precio = 45 },
                new Pizza { Ingredientes = new List<string>() { "Queso", "Salsa", "Tomate", "Albahaca" }, Nombre = "Margarita", Precio = 40 }
                );
        }
    }
}
