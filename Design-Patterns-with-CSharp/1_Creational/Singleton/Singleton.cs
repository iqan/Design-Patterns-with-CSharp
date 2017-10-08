namespace _1_Creational.Singleton
{
    public class Singleton
    {
        
    }

    public class MyFavoriteiriyani
    {
        private static MyFavoriteiriyani _biryani;
        private static readonly object _syncObject = new object() { };

        private MyFavoriteiriyani()
        {
        }

        public static MyFavoriteiriyani Biriyani
        {
            get
            {
                if (_biryani == null)
                {
                    lock (_syncObject)
                    {
                        _biryani = new MyFavoriteiriyani();
                    }
                }
                return _biryani;
            }
        }

        public int BiriyaniPlates { get; set; }
    }
}
