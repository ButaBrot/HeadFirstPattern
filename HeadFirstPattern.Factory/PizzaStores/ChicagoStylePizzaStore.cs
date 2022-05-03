using HeadFirstPattern.Factory.Fabric;
using HeadFirstPattern.Factory.Pizzas;

namespace HeadFirstPattern.Factory.PizzaStores;

public class ChicagoStylePizzaStore:PizzaStore
{
    public ChicagoStylePizzaStore(SimplePizzaFactory factory) : base(factory)
    {
    }

    public override IPizza CreatePizza(string type)
    {
        IPizza? pizza = type switch
        {
            "cheese" => new ChicagoCheesePizza(),
            "pepperoni" => new ChicagoPepperoniPizza(),
            "clam" => new ChicagoClamPizza(),
            "veggie" => new ChicagoVeggiePizza(),
            _ => null
        };
        return pizza;
    }
}