namespace HeadFirstPattern.Decorator.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        public override string Description { get => Beverage.Description + " ,Mocha"; set => base.Description = value; }
        public Mocha(Beverage beverage) : base(beverage)
        {

        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.23f;
        }
    }
}
