#region

using HeadFirstPattern.Factory.Fabric;
using HeadFirstPattern.Factory.Pizzas;

#endregion

namespace HeadFirstPattern.Factory;

public abstract class PizzaStore
{
    public PizzaStore(SimplePizzaFactory factory)
    {
        Factory = factory;
    }
    public SimplePizzaFactory Factory { get; set; }
    public IPizza? OrderPizza(string type)
    {
        var pizza = Factory.createPizza("pepperoni");
        pizza?.Prepare();
        pizza?.Bake();
        pizza?.Cut();
        pizza?.Box();
        return pizza;
    }

    public abstract IPizza CreatePizza(string type);
}