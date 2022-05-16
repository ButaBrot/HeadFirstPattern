using HeadFirstPattern.Adapter;
using HeadFirstPattern.Adapter.Adapter;

IDuck   duck   = new MallardDuck();
ITurkey turkey = new WildTurkey();

IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine($"Ein Truthahn macht:");
turkey.Gobble();
turkey.Fly();
Console.WriteLine($"Eine Ente macht:");
TestDuck(duck);
Console.WriteLine($"Der TurkeyAdapter macht:");
TestDuck(turkeyAdapter);

void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
    
}
