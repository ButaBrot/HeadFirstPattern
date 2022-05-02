#region

using System.ComponentModel;
using System.Globalization;
using HeadFirstPattern.Factory.Fabric;
using HeadFirstPattern.Factory.Pizzas;

#endregion

namespace HeadFirstPattern.Factory;

public class PizzaStore
{
    public SimplePizzaFactory Factory { get; set; }

    public PizzaStore(SimplePizzaFactory factory) => Factory = factory;

    void test()
    {
        
    }

    public IPizza? OrderPizza(string type)
    {
        var pizza = Factory.createPizza("pepperoni");
        pizza?.Prepare();
        pizza?.Bake();
        pizza?.Cut();
        pizza?.Box();
        return pizza;
    }

    
}
