using PizzaDelivery.API.Core.Entities;
using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Core.Services
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._pizza = new Pizza();
        }

        public void ConstruirNombre(string nombre)
        {
            this._pizza.Nombre = nombre;
        }

        public void ConstruirIngredientes(List<string> ingredientes)
        {
            this._pizza.Ingredientes = ingredientes;
        }

        public void ConstruirPrecio(decimal precio)
        {
            this._pizza.Precio = precio;
        }

        public Pizza ObtenerPizza()
        {
            Pizza resultado = this._pizza;
            this.Reset();
            return resultado;
        }
    }
}
