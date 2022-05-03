namespace HeadFirstPattern.Factory.Pizzas;

public class NYCheesePizza : Pizza
{
    public NYCheesePizza()
    {
        Name = "Pizza nach New Yorker Art";
        Dough = "Teig fuer duennen Boden";
        Sauce = "Marinara-Sosse";

        Toppings.Add("Geriebener Reggionakaese");
    }

        
}