using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Core.Services
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void ConstruirPizza(string nombre, List<string> ingredientes, decimal precio)
        
        {
            _builder.ConstruirNombre(nombre);
            _builder.ConstruirIngredientes(ingredientes);
            _builder.ConstruirPrecio(precio);
        }
    }
}
