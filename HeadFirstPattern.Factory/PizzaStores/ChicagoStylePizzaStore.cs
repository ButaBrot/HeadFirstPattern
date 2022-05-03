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
            "cheese" => new NYCheesePizza(),
            "pepperoni" => new PepperoniPizza(),
            "clam" => new ClamPizza(),
            "veggie" => new VeggiePizza(),
            _ => null
        };
        return pizza;
    }
}