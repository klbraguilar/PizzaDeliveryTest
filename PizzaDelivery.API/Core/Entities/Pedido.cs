namespace PizzaDelivery.API.Core.Entities
{
    public class Pedido
    {
        public List<PizzaPedido> Pizzas { get; set; }
        public bool EsMartesOMiercoles { get; set; }
        public bool EsJueves { get; set; }
    }
}
