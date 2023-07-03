using PizzaDelivery.API.Core.Entities;

namespace PizzaDelivery.API.Core.Interfaces
{
    public interface IDescuentoStrategy
    {
        decimal AplicarDescuento(decimal precio, bool esMartesOMiercoles);
    }
}
