using System.Linq;
using NUnit.Framework;
using _2_Behavioral.TemplateMethod;

namespace _2_Behavioral_Tests.TemplateMethod
{
    [TestFixture]
    public class TemplateMethodTests
    {
        [Test]
        public void HyderabadiBiriyaniStore_Should_Deliver_HyderabadiDumBiriyani()
        {
            var hyderabadiBiriyaniStore = new HyderabadiBiriyaniStore();

            var biriyani = hyderabadiBiriyaniStore.OrderBiriyani();

            Assert.AreEqual("Confirm: Confirmed by Hyderabadi House."
                , hyderabadiBiriyaniStore.StepsPerformed.FirstOrDefault(s => s.StartsWith("Confirm")));
            Assert.AreEqual("Cook: Cooked Aroma Hyderabadi dum biriyani."
                , hyderabadiBiriyaniStore.StepsPerformed.FirstOrDefault(s=>s.StartsWith("Cook")));
            Assert.AreEqual("Pack: Packed with Raita and Salad."
                , hyderabadiBiriyaniStore.StepsPerformed.FirstOrDefault(s => s.StartsWith("Pack")));
        }

        [Test]
        public void A1BiriyaniStore_Should_Deliver_A1SpecialBiriyani()
        {
            var a1BiriyaniStore = new A1BiriyaniStore();

            var biriyani = a1BiriyaniStore.OrderBiriyani();

            Assert.AreEqual("Confirm: Confirmed by A1 Biriyani House."
                , a1BiriyaniStore.StepsPerformed.FirstOrDefault(s => s.StartsWith("Confirm")));
            Assert.AreEqual("Cook: Cooked A1 Special biriyani."
                , a1BiriyaniStore.StepsPerformed.FirstOrDefault(s => s.StartsWith("Cook")));
            Assert.AreEqual("Pack: Packed with Chutney and Salad."
                , a1BiriyaniStore.StepsPerformed.FirstOrDefault(s => s.StartsWith("Pack")));
        }
    }
}
