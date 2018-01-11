using NUnit.Framework;

namespace _1_Creational.Prototype
{
    [TestFixture]
    public class PrototypeTests
    {
        [Test]
        public void SweetBiryani_Should_Create_Another_SweetBiryani()
        {
            var sweetBiriyani = new SweetBiriyani();
            var anotherBiriyani = sweetBiriyani.Clone();

            Assert.AreEqual(sweetBiriyani.IsSweet, anotherBiriyani.IsSweet);
            Assert.AreEqual(sweetBiriyani.IsSpicy, anotherBiriyani.IsSpicy);
            Assert.AreEqual(sweetBiriyani.HasEdibleColor, anotherBiriyani.HasEdibleColor);

            Assert.AreNotSame(sweetBiriyani, anotherBiriyani);
        }

        [Test]
        public void SpicyBiryani_Should_Create_Another_SpicyBiryani()
        {
            var spicyBiriyani = new SpicyBiriyani();
            var anotherBiriyani = spicyBiriyani.Clone();

            Assert.AreEqual(spicyBiriyani.IsSweet, anotherBiriyani.IsSweet);
            Assert.AreEqual(spicyBiriyani.IsSpicy, anotherBiriyani.IsSpicy);
            Assert.AreEqual(spicyBiriyani.HasEdibleColor, anotherBiriyani.HasEdibleColor);

            Assert.AreNotSame(spicyBiriyani, anotherBiriyani);
        }

        [Test]
        public void RamboBiryani_Should_Create_Another_RamboBiryani()
        {
            var ramboBiriyani = new RamboBiriyani();
            var anotherBiriyani = ramboBiriyani.Clone();

            Assert.AreEqual(ramboBiriyani.IsSweet, anotherBiriyani.IsSweet);
            Assert.AreEqual(ramboBiriyani.IsSpicy, anotherBiriyani.IsSpicy);
            Assert.AreEqual(ramboBiriyani.HasEdibleColor, anotherBiriyani.HasEdibleColor);

            Assert.AreNotSame(ramboBiriyani, anotherBiriyani);
        }
    }
}
