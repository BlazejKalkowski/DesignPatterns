
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
            Console.WriteLine($"Pizza {pizza.KindOfPizza} making process is over.");
        }
    }
}
