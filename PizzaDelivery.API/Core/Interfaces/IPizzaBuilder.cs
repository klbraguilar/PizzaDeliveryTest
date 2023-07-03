using PizzaDelivery.API.Core.Entities;

namespace PizzaDelivery.API.Core.Interfaces
{
    public interface IPizzaBuilder
    {
        void ConstruirNombre(string nombre);
        void ConstruirIngredientes(List<string> ingredientes);
        void ConstruirPrecio(decimal precio);
        Pizza ObtenerPizza();
    }
}
