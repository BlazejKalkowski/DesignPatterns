using Facade;

var pizza = new Pizza() { Id = 1, KindOfPizza = KindOfPizza.Diavola };
var orderOfPizza = new PizzaFasade();

await orderOfPizza.OrderAsync(pizza);

Console.WriteLine("Stopped fasade design pattern...");
