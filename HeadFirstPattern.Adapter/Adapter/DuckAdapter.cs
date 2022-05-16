namespace HeadFirstPattern.Adapter.Adapter;

public class DuckAdapter:ITurkey
{
    private IDuck duck;

    public DuckAdapter(IDuck duck)
    {
        this.duck = duck;
    }

    public void Gobble()
    {
        duck.Quack();
    }

    public void Fly()
    {
        duck.Fly();
    }
}