namespace HeadFirstPattern.Decorator.Beverages
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
