namespace _2_Behavioral.Strategy
{
    public interface IRestaurant
    {
        ISpecialDish OrderSpecialDish();
    }

    public class WestIndianRestaurant : IRestaurant
    {
        public ISpecialDish OrderSpecialDish()
        {
            return new Dhokla();
        }
    }

    public class NorthIndianRestaurant : IRestaurant
    {
        public ISpecialDish OrderSpecialDish()
        {
            return new ChholeBhature();
        }
    }

    public class EastIndianRestaurant : IRestaurant
    {
        public ISpecialDish OrderSpecialDish()
        {
            return new KoshaMangsho();
        }
    }

    public class SouthIndianRestaurant : IRestaurant
    {
        public ISpecialDish OrderSpecialDish()
        {
            return new Dosa();
        }
    }
}
