using System.Linq;
using NUnit.Framework;
using _2_Behavioral.Observer;

namespace _2_Behavioral_Tests.Observer
{
    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void BadmintonOrganizer_Should_Notify_Subscribed_Audiences()
        {
            var newspaper = new NewsPaper();
            var radio = new Radio();
            var tv = new Television();

            var badmintonOrg = new BadmintonOrganizer();
            badmintonOrg.RegisterAudience(newspaper);
            badmintonOrg.RegisterAudience(radio);
            badmintonOrg.RegisterAudience(tv);

            var finalResult = new GameResult
            {
                WinningTeamName = "India",
                LosingTeamName = "China",
                WinningTeamScore = 21,
                LosingTeamScore = 18
            };

            badmintonOrg.AfterGameIsDone(finalResult);

            Assert.AreEqual(finalResult, newspaper.GameResults.First());
            Assert.AreEqual(finalResult, radio.GameResults.First());
            Assert.AreEqual(finalResult, tv.GameResults.First());
        }
    }
}
