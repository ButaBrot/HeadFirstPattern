namespace HeadFirstPattern.Decorator.Beverages
{
    internal class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.89;
        }
    }
}
