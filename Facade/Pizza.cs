namespace Facade
{
    public class Pizza
    {
        public int Id { get; set; }
        public PizzaType PizzaType { get; set; }
    }

    public enum PizzaType
    {
        Margherita,
        Capriciosa,
        Diavola
    }
}
