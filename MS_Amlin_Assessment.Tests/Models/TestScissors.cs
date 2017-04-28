using MS_Amlin_Assessment.Models;
using NUnit.Framework;

namespace MS_Amlin_Assessment.Tests
{
    [TestFixture]
    public class TestScissors
    {
        [Test]
        public void TestShouldBeatPaper()
        {
            Scissors scissors = new Scissors();
            Paper paper = new Paper();

            var expected = 1;

            Assert.AreEqual(expected, scissors.Beats(paper));
        }

        [Test]
        public void TestShouldNotBeatRock()
        {
            Scissors scissors = new Scissors();
            Rock rock = new Rock();

            var expected = -1;

            Assert.AreEqual(expected, scissors.Beats(rock));
        }

        [Test]
        public void TestShouldTieScissors()
        {
            Scissors scissors1 = new Scissors();
            Scissors scissors2 = new Scissors();

            var expected = 0;
            Assert.AreEqual(expected, scissors2.Beats(scissors1));
        }

    }
}