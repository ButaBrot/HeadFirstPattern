namespace HeadFirstPattern.Adapter;

public class MallardDuck : IDuck
{
    public void Quack()
    {
        Console.WriteLine($"Quack!");
    }

    public void Fly()
    {
        Console.WriteLine($"Ich fliege!");
    }
}