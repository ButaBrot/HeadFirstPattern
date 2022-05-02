using HeadFirstPattern.Factory.Fabric;
using HeadFirstPattern.Factory.Pizzas;

namespace HeadFirstPattern.Factory.PizzaStores;

public class NYStylePizzaStore:PizzaStore
{
    public NYStylePizzaStore(SimplePizzaFactory factory) : base(factory)
    {
    }

    public override IPizza CreatePizza(string type)
    {
        throw new NotImplementedException();
    }
}