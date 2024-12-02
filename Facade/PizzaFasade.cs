namespace Facade
{
    internal interface IPizza
    {
        Task OrderAsync(Pizza pizza);
    }

    internal class PizzaFasade : IPizza
    {
        IMakePizza _makePizza;
        INotification _notification;

        public PizzaFasade(IMakePizza makePizza, INotification notification)
        {
            _makePizza = makePizza;
            _notification = notification;
        }
        public PizzaFasade()
        {
            _makePizza = new MakePizza();
            _notification = new Notification();
        }

        public async Task OrderAsync(Pizza pizza)
        {
            await _makePizza.MakeAsync(pizza);
            _notification.Notify(pizza);
        }
    }
}
