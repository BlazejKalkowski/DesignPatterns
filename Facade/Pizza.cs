namespace Facade
{
    public class Pizza
    {
        public int Id { get; set; }
        public KindOfPizza KindOfPizza { get; set; }
    }

    public enum KindOfPizza
    {
        Margharitta,
        Capriciosa,
        Diavola
    }
}
