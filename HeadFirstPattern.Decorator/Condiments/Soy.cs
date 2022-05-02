namespace HeadFirstPattern.Decorator.Condiments
{
    internal class Soy : CondimentDecorator
    {
        public override string Description { get => Beverage.Description + " ,Soy"; set => base.Description = value; }
        public Soy(Beverage beverage) : base(beverage)
        {

        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.63f;
        }
    }
}
