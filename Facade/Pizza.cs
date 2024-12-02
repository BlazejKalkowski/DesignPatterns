namespace Facade
{
    public class Pizza
    {
        public int Id { get; set; }
        public PizzaType KindOfPizza { get; set; }
    }

    public enum PizzaType
    {
        Margherita,
        Capriciosa,
        Diavola
    }
}
