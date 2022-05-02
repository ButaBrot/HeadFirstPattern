namespace HeadFirstPattern.Decorator
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public abstract override string Description { get; }

        public Beverage Beverage { get; }
    }
}
