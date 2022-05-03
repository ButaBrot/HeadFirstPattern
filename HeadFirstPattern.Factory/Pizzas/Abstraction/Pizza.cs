namespace HeadFirstPattern.Factory.Pizzas;

public abstract class Pizza
{
    public  string Name { get;  set; }
    public  string Dough { get; set; }
    public  string Sauce { get; set; }
    public  List<string> Toppings { get;  set; }
    public Pizza()
    {
        Toppings = new List<string>();
    }
    public virtual void Prepare()
    {
        Console.WriteLine($"Vorbereitung fuer: {Name}");
        Console.WriteLine("Knete Teig....");
        Console.WriteLine("Fuege Sosse hinzu....");
        Console.Write("Fuege Belaege hinzu: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($" {topping}");
        }
    }
    public virtual void Bake()
    {
        Console.WriteLine("Backe fuer 25 Minuten bei 350 Grad");
    }
    public virtual void Cut()
    {
        Console.WriteLine("Schneide Pizza diagonal in Stuecke");
    }
    public virtual void Box()
    {
        Console.WriteLine("Lege Pizza in offiziellen PizzaStore-Karton");
    }
}