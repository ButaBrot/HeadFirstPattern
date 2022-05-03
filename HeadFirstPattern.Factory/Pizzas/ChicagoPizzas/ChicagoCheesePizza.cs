namespace HeadFirstPattern.Factory.Pizzas;

public class ChicagoCheesePizza : Pizza
{
    public ChicagoCheesePizza()
    {
        Name = "Pizza nach Chicago-Art";
        Dough = "Teig fuer extradicken Boden";
        Sauce = "Datteltomatensosse";
        Toppings.Add("Grob geriebener Mozzarellakaese");
    }
    public override void Cut() => Console.WriteLine("Schneide Pizza in quadratische Stuecke");
}