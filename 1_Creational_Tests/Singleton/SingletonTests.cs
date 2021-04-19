using NUnit.Framework;

namespace _1_Creational.Singleton
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void MyFavoriteBiriyani_Should_Always_Return_Same_Biriyani()
        {
            var myFavoriteBiriyani1 = MyFavoriteBiriyani.Biriyani;
            var myFavoriteBiriyani2 = MyFavoriteBiriyani.Biriyani;

            Assert.AreSame(myFavoriteBiriyani1, myFavoriteBiriyani2);

            myFavoriteBiriyani1.BiriyaniPlates++;
            Assert.AreEqual(myFavoriteBiriyani1.BiriyaniPlates, myFavoriteBiriyani2.BiriyaniPlates);

            myFavoriteBiriyani2.BiriyaniPlates++;
            Assert.AreEqual(myFavoriteBiriyani2.BiriyaniPlates, myFavoriteBiriyani1.BiriyaniPlates);
        }
    }
}
