using NUnit.Framework;

namespace _1_Creational.Builder
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void SimpleReciepe_Should_Create_Biriyani_With_Simple_Steps()
        {
            var receipeSteps = "Simple preparation step. Simple cooking step.";
            var receipe = new SimpleBiriyaniReciepe();
            var builder = new Builder(receipe);

            builder.Build();
            var biriyani = receipe.GetBiriyani();

            var stepsPerformed = biriyani.ShowSteps();
            Assert.AreEqual(receipeSteps, stepsPerformed);
        }

        [Test]
        public void SpecialReciepe_Should_Create_Biriyani_With_Special_Steps()
        {
            var receipeSteps = "Special preparation step. Special cooking step.";
            var receipe = new SpecialBiriyaniReciepe();
            var builder = new Builder(receipe);

            builder.Build();
            var biriyani = receipe.GetBiriyani();

            var stepsPerformed = biriyani.ShowSteps();
            Assert.AreEqual(receipeSteps, stepsPerformed);
        }
    }
}
