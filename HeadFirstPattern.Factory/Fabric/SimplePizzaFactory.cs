#region

using HeadFirstPattern.Factory.Pizzas;

#endregion

namespace HeadFirstPattern.Factory.Fabric;

public class SimplePizzaFactory
{
    public IPizza? createPizza(string type)
    {
        IPizza? pizza = type switch
                        {
                            "cheese"    => new CheesePizza(),
                            "pepperoni" => new PepperoniPizza(),
                            "clam"      => new ClamPizza(),
                            "veggie"    => new VeggiePizza(),
                            _           => null
                        };
        return pizza;
    }
}