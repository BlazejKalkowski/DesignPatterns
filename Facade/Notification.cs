
namespace Facade
{
    internal interface INotification
    {
        void Notify(Pizza pizza);
    }

    internal class Notification : INotification
    {
        void INotification.Notify(Pizza pizza)
        {
            Console.WriteLine($"Pizza {pizza.PizzaType} making process is over.");
        }
    }
}
