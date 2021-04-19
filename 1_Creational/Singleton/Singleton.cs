namespace _1_Creational.Singleton
{
    public class Singleton
    {
        
    }

    public class MyFavoriteBiriyani
    {
        private static MyFavoriteBiriyani _biryani;
        private static readonly object _syncObject = new object() { };

        private MyFavoriteBiriyani()
        {
        }

        public static MyFavoriteBiriyani Biriyani
        {
            get
            {
                if (_biryani == null)
                {
                    lock (_syncObject)
                    {
                        _biryani = new MyFavoriteBiriyani();
                    }
                }
                return _biryani;
            }
        }

        public int BiriyaniPlates { get; set; }
    }
}
