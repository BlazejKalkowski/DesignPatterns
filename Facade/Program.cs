using Facade;

IMakePizza pizzaMaker = new MakePizza();
INotification notification = new Notification();

var pizza = new Pizza() { Id = 1, PizzaType = PizzaType.Diavola };
var orderOfPizza = new PizzaFasade(pizzaMaker,notification);

await orderOfPizza.OrderAsync(pizza);

