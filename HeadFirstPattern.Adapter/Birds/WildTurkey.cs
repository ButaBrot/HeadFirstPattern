namespace HeadFirstPattern.Adapter;

class WildTurkey:ITurkey
{
    public void Gobble()
    {
        Console.WriteLine($"Gooble,Gooble!");
    }

    public void Fly()
    {
        Console.WriteLine($"Ich fliege ein kleines Stueck!");
    }
}
