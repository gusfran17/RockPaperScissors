using MS_Amlin_Assessment.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Amlin_Assessment.Tests.Models
{
    [TestFixture]
    class TestPlayer
    {
        [Test]
        public void TestShouldReturnRock()
        {
            Player player = new Player();
            Shape shape = player.ShowShape(Shapes.Rock.ToString());

            var expected = typeof(Rock);

            Assert.IsInstanceOf(expected, shape);
        }

        [Test]
        public void TestShouldReturnPaper()
        {
            Player player = new Player();
            Shape shape = player.ShowShape(Shapes.Paper.ToString());

            var expected = typeof(Paper);

            Assert.IsInstanceOf(expected, shape);
        }

        [Test]
        public void TestShouldReturnScissors()
        {
            Player player = new Player();
            Shape shape = player.ShowShape(Shapes.Scissors.ToString());

            var expected = typeof(Scissors);

            Assert.IsInstanceOf(expected, shape);
        }

        [Test]
        public void TestPaperShouldBeatRock()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Shape paper = player1.ShowShape(Shapes.Rock.ToString());
            Shape rock = player2.ShowShape(Shapes.Paper.ToString());

            var expected = 1;

            Assert.AreEqual(expected, paper.Beats(rock));
        }
    }
}
