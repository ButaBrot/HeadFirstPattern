using HeadFirstPattern.Factory.Pizzas;

namespace HeadFirstPattern.Factory.PizzaStores;

public class ChicagoStylePizzaStore : PizzaStore
{

    public override Pizza CreatePizza(string type)
    {
        Pizza? pizza = type switch
        {
            "cheese" => new ChicagoCheesePizza(),
            //"pepperoni" => new ChicagoPepperoniPizza(),
            //"clam" => new ChicagoClamPizza(),
            //"veggie" => new ChicagoVeggiePizza(),
            _ => null
        };
        return pizza;
    }
}