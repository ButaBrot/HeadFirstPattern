namespace HeadFirstPattern.Template
{
    internal class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Lasse den Tee ziehen.");
        }


        public override void AddCondiments()
        {
            Console.WriteLine("Fuege Zintrone zu.");
        }
    }
}
