using NUnit.Framework;
using _1_Creational.Factory.Classes;

namespace _1_Creational.Factory
{
    [TestFixture]
    public class A_SimpleFactoryTests
    {
        [Test]
        public void ChickenBiriyani_Should_Be_Created_When_Given_ChickenType()
        {
            var biriyani = A_SimpleFactory.CreateBiriyani(BiriyaniTypes.ChickenBiriyani);

            Assert.IsInstanceOf<ChickenBiriyani>(biriyani);
        }

        [Test]
        public void MuttonBiriyani_Should_Be_Created_When_Given_MuttonType()
        {
            var biriyani = A_SimpleFactory.CreateBiriyani(BiriyaniTypes.MuttonBiriyani);

            Assert.IsInstanceOf<MuttonBiriyani>(biriyani);
        }

        [Test]
        public void FishBiriyani_Should_Be_Created_When_Given_FishType()
        {
            var biriyani = A_SimpleFactory.CreateBiriyani(BiriyaniTypes.FishBiriyani);

            Assert.IsInstanceOf<FishBiriyani>(biriyani);
        }

        [Test]
        public void VegBiriyani_Should_Be_Created_When_Given_VegType()
        {
            var biriyani = A_SimpleFactory.CreateBiriyani(BiriyaniTypes.VegBiriyani);

            Assert.IsInstanceOf<VegBiriyani>(biriyani);
        }
    }
}
