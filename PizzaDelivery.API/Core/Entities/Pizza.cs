namespace PizzaDelivery.API.Core.Entities
{
    public class Pizza
    {
        public string Nombre { get; set; } = string.Empty;
        public List<string> Ingredientes { get; set; } 
        public decimal Precio { get; set; }



    }
}
