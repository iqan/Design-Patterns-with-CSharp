namespace _2_Behavioral.Strategy
{
    public interface IRestaurant
    {
        string OrderSpecialDish();
    }

    public class WestIndianRestaurant : IRestaurant
    {
        public string OrderSpecialDish()
        {
            return "Dhokla";
        }
    }

    public class NorthIndianRestaurant : IRestaurant
    {
        public string OrderSpecialDish()
        {
            return "ChholeBhature";
        }
    }

    public class EastIndianRestaurant : IRestaurant
    {
        public string OrderSpecialDish()
        {
            return "KoshaMangsho";
        }
    }

    public class SouthIndianRestaurant : IRestaurant
    {
        public string OrderSpecialDish()
        {
            return "Dosa";
        }
    }
}
