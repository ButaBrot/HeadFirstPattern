#region

using HeadFirstPattern.Factory.Pizzas;

#endregion

namespace HeadFirstPattern.Factory.Fabric;

public class SimplePizzaFactory
{
    public Pizza? createPizza(string type)
    {
        Pizza? pizza = type switch
                        {
                            "cheese"    => new NYCheesePizza(),
                            //"pepperoni" => new PepperoniPizza(),
                            //"clam"      => new ClamPizza(),
                            //"veggie"    => new VeggiePizza(),
                            _           => null
                        };
        return pizza;
    }
}