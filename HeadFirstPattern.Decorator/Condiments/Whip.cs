namespace HeadFirstPattern.Decorator.Condiments
{
    internal class Whip : CondimentDecorator
    {
        public override string Description { get => Beverage.Description + " ,Whip"; set => base.Description = value; }
        public Whip(Beverage beverage) : base(beverage)
        {

        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.53f;
        }
    }
}
