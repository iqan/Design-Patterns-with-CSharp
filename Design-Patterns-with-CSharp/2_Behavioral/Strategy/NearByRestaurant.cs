namespace _2_Behavioral.Strategy
{
    public abstract class NearByRestaurant
    {
        private IRestaurant _restaurant;

        public NearByRestaurant(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public string OrderSpecialDishOfRestaurant()
        {
            return _restaurant.OrderSpecialDish();
        }

        public void ChangeRestaurantType(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }
    }

    public class A1Restaurant : NearByRestaurant
    {
        public A1Restaurant(IRestaurant restaurant) : base(restaurant)
        {
        }
    }

    public class WowRestaurant : NearByRestaurant
    {
        public WowRestaurant(IRestaurant restaurant) : base(restaurant)
        {
        }
    }
}
