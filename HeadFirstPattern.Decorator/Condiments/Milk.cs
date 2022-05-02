namespace HeadFirstPattern.Decorator.Condiments
{
    internal class Milk : CondimentDecorator
    {
        public override string Description { get => Beverage.Description + " ,Milk"; set => base.Description = value; }
        public Milk(Beverage beverage) : base(beverage)
        {
            // Beverage = beverage;
        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.43f;
        }
    }
}
