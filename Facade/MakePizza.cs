namespace Facade
{
    internal interface IMakePizza
    {
        Task MakeAsync(Pizza pizza);
    }

    internal class MakePizza : IMakePizza
    {
        public async Task MakeAsync(Pizza pizza)
        {
            Console.WriteLine($"Pizza {pizza.PizzaType} is making... " +
                $"We will notify you when process is complete.");
            await Task.Delay(300);
        }
    }
}
