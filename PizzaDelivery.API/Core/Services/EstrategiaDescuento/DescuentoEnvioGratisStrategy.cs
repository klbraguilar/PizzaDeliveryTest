using PizzaDelivery.API.Core.Interfaces;

namespace PizzaDelivery.API.Core.Services.EstrategiaDescuento
{
    public class DescuentoEnvioGratisStrategy : IDescuentoStrategy
    {
        public decimal AplicarDescuento(decimal precio, bool esJueves)
        {
            if (esJueves)
            {
                precio = 0;
            }

            return precio;
        }
    }
}
