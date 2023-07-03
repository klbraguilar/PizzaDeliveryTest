using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Core.Services.EstrategiaDescuento
{
    public class DescuentoPorDefectoStrategy : IDescuentoStrategy
    {
        public decimal AplicarDescuento(decimal precio, bool esMartesOMiercoles)
        {
            return precio;
        }
    }
}
