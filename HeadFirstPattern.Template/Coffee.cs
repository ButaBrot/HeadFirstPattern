namespace HeadFirstPattern.Template
{
    internal class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Lasse Kaffee durch den Filter laufen.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Fuege Milch und Zucker zu.");
        }
    }
}
