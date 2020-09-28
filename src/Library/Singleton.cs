namespace Library
{
    public interface Singleton<T> where T : Greeter
    {
        private static Greeter instance;
        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }
        
        
        
         
    }
}