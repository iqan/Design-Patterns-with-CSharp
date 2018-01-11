using System.Collections.Generic;
using NUnit.Framework;
using _3_Structural.Decorator;

namespace _3_Structural_Tests.Decorator
{
    [TestFixture]
    public class DecoratorTests
    {
        [Test]
        public void CustomBiriyani_Should_Cost_More_And_Have_Extra_Ingredients()
        {
            var ingredients = new List<string>
            {
                "Rice",
                "Chicken",
                "Special Spicies",
                "Chicken Wings"
            };

            var simpleChickenBiriyani = new SimpleChickenBiriyani();
            var biriyaniWithExtraSpicies = new BiriyaniWithExtraSpicies(simpleChickenBiriyani);

            var biriyani = new ChickenBiriyaniWithExtraWings(biriyaniWithExtraSpicies);

            Assert.AreEqual(325, biriyani.Cost);
            Assert.Contains("Rice", biriyani.Ingredients);
            Assert.Contains("Chicken", biriyani.Ingredients);
            Assert.Contains("Special Spicies", biriyani.Ingredients);
            Assert.Contains("Chicken Wings", biriyani.Ingredients);
        }
    }
}
