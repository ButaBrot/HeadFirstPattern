using HeadFirstPattern.Factory;
using HeadFirstPattern.Factory.PizzaStores;

PizzaStore nyStore = new NYStylePizzaStore();
PizzaStore chicagoStore = new ChicagoStylePizzaStore();

var pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan bestellte eine {pizza.Name}");
pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel bestellte eine {pizza.Name}"); 
