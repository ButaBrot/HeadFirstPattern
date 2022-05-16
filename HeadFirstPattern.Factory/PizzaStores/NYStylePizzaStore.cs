using HeadFirstPattern.Factory.Pizzas;

namespace HeadFirstPattern.Factory.PizzaStores;

public class NYStylePizzaStore:PizzaStore
{
    

    public override Pizza CreatePizza(string type)
    {
        Pizza? pizza = type switch
        {
            "cheese" => new NYCheesePizza(),
            //"pepperoni" => new NYPepperoniPizza(),
            //"clam" => new NYClamPizza(),
            //"veggie" => new NYVeggiePizza(),
            _ => null
        };
        return pizza;
    }
}