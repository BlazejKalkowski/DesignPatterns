using Facade;

IMakePizza pizzaMaker = new MakePizza();
INotification notification = new Notification();

var pizza = new Pizza() { Id = 1, KindOfPizza = PizzaType.Diavola };
var orderOfPizza = new PizzaFasade();

await orderOfPizza.OrderAsync(pizza);

