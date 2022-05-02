namespace HeadFirstPattern.Decorator
{
    internal abstract class Beverage
    {
        private string description = "Unbekanntes Getraenk";

        public virtual string Description { get => description; set => description = value; }

        public abstract double Cost();
    }
}
