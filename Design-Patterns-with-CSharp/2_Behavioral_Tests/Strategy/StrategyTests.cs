using NUnit.Framework;
using _2_Behavioral.Strategy;

namespace _2_Behavioral_Tests.Strategy
{
    [TestFixture]
    public class StrategyTests
    {
        [Test]
        public void A1Restaurant_Should_Provide_Dhokla_When_Ordered_Special_Dish()
        {
            var restaurant = new A1Restaurant(new WestIndianRestaurant());
            var specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<Dhokla>(specialDish);
        }

        [Test]
        public void A1Restaurant_Should_Provide_Dosa_When_Ordered_Special_Dish()
        {
            var restaurant = new A1Restaurant(new SouthIndianRestaurant());
            var specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<Dosa>(specialDish);
        }

        [Test]
        public void A1Restaurant_Should_Provide_ChholeBhature_When_Ordered_Special_Dish()
        {
            var restaurant = new A1Restaurant(new NorthIndianRestaurant());
            var specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<ChholeBhature>(specialDish);
        }

        [Test]
        public void A1Restaurant_Should_Provide_KoshaMangsho_When_Ordered_Special_Dish()
        {
            var restaurant = new A1Restaurant(new EastIndianRestaurant());
            var specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<KoshaMangsho>(specialDish);
        }

        [Test]
        public void A1Restaurant_Should_Provide_Changed_Special_Dish()
        {
            var restaurant = new A1Restaurant(new EastIndianRestaurant());
            var specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<KoshaMangsho>(specialDish);

            // Now changing restaurant type
            restaurant.ChangeRestaurantType(new WestIndianRestaurant());
            specialDish = restaurant.OrderSpecialDishOfRestaurant();

            Assert.IsInstanceOf<Dhokla>(specialDish);
        }
    }
}
