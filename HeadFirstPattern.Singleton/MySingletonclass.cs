namespace HeadFirstPattern.Singleton
{
    internal class MySingletonclass
    {
        private static MySingletonclass _instance;

        public Guid MyGuid { get; set; }
        MySingletonclass()
        {
            MyGuid = Guid.NewGuid();
            
        }
        public static MySingletonclass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance=new MySingletonclass();
                }
                return _instance;
            }
           
        }
    }
}
