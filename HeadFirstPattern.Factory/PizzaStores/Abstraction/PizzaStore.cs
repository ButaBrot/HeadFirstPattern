#region

using HeadFirstPattern.Factory.Fabric;
using HeadFirstPattern.Factory.Pizzas;

#endregion

namespace HeadFirstPattern.Factory;

public abstract class PizzaStore
{
    
    public SimplePizzaFactory Factory { get; set; }
    public Pizza? OrderPizza(string type)
    {
        var pizza = CreatePizza(type);
        pizza?.Prepare();
        pizza?.Bake();
        pizza?.Cut();
        pizza?.Box();
        return pizza;
    }

    public abstract Pizza CreatePizza(string type);
}