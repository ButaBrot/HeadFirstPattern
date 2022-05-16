namespace HeadFirstPattern.Singleton
{
    internal class ChocolateBoiler
    {
        public bool IsEmpty { get; set; }
        public bool IsBoiled { get; set; }
        public Guid MyGuid { get; set; }= Guid.NewGuid();
        private static ChocolateBoiler _instance;

        public static ChocolateBoiler Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ChocolateBoiler();
                }
                return _instance; }
        }

        private ChocolateBoiler() { }
        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
                IsBoiled = false;
            }
        }
        public void Drain()
        {
            if (!IsEmpty&&IsBoiled)
            {
                IsEmpty = true;
            }
        }
        public void Boil()
        {
            if (!IsEmpty && !IsBoiled)
            {
                IsBoiled = true;
            }
        }
    }
}
