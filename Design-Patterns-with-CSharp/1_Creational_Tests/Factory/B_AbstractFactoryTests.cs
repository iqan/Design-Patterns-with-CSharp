using NUnit.Framework;
using _1_Creational.Factory.Classes;

namespace _1_Creational.Factory
{
    [TestFixture]
    public class B_AbstractFactoryTests
    {
        [Test]
        public void SimpleBiryaniFactory_Should_Create_Veg_When_Asked_For_Veg_Biriyani()
        {
            var factory = new SimpleBiriyaniFactory();
            var biriyani = factory.CreateVegBiriyani();

            Assert.IsInstanceOf<VegBiriyani>(biriyani);
        }

        [Test]
        public void SimpleBiryaniFactory_Should_Create_Chicken_When_Asked_For_NonVeg_Biriyani()
        {
            var factory = new SimpleBiriyaniFactory();
            var biriyani = factory.CreateNonVegBiriyani();

            Assert.IsInstanceOf<ChickenBiriyani>(biriyani);
        }

        [Test]
        public void SpecialBiryaniFactory_Should_Create_Veg_When_Asked_For_Veg_Biriyani()
        {
            var factory = new SpecialBiriyaniFactory();
            var biriyani = factory.CreateVegBiriyani();

            Assert.IsInstanceOf<VegBiriyani>(biriyani);
        }

        [Test]
        public void SpecialBiryaniFactory_Should_Create_Mutton_When_Asked_For_NonVeg_Biriyani()
        {
            var factory = new SpecialBiriyaniFactory();
            var biriyani = factory.CreateNonVegBiriyani();

            Assert.IsInstanceOf<MuttonBiriyani>(biriyani);
        }
    }
}
