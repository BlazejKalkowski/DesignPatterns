namespace Facade
{
    internal interface IPizza
    {
        Task OrderAsync(Pizza pizza);
    }
    internal class PizzaFasade : IPizza
    {
        IMakePizza _makePizza;
        INotification _notify;

        public PizzaFasade()
        {
            _makePizza = new MakePizza();
            _notify = new Notification();
        }

        public async Task OrderAsync(Pizza pizza)
        {
            await _makePizza.MakeAsync(pizza);
            _notify.Notify(pizza);
        }
    }
}
