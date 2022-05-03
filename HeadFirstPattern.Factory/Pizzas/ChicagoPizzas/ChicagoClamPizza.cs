namespace HeadFirstPattern.Factory.Pizzas;

public class ChicagoClamPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Prepare Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Bake Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cut Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Box Pizza");
    }
}