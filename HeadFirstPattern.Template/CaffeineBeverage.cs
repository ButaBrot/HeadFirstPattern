namespace HeadFirstPattern.Template
{
    internal abstract class CaffeineBeverage
    {

      
        virtual public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        abstract public void Brew();
        abstract public void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Koche Wasser.");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Giesse das Getraenk in Tasse.");
        }
    }
}