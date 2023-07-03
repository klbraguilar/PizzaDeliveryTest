using Humanizer.DateTimeHumanizeStrategy;
using PizzaDelivery.API.Core.Entities;
using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Core.Services.EstrategiaDescuento
{
    public class Descuento2x1Strategy : IDescuentoStrategy
    {
        public decimal AplicarDescuento(decimal precio, bool esMartesOMiercoles)
        {
            if (esMartesOMiercoles)
            {
                precio = precio / 2;
            }

            return precio;
        }
    }
}
