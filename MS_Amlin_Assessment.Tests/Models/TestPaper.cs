using MS_Amlin_Assessment.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Amlin_Assessment.Tests.Models
{
    class TestPaper
    {
        [Test]
        public void TestShouldBeatRock()
        {
            Paper paper = new Paper();
            Rock rock = new Rock();

            var expected = 1;

            Assert.AreEqual(expected, paper.Beats(rock));
        }

        [Test]
        public void TestShouldNotBeatScissors()
        {
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            
            var expected = -1;

            Assert.AreEqual(expected, paper.Beats(scissors));
        }

        [Test]
        public void TestShouldTiePaper()
        {
            Paper paper1 = new Paper();
            Paper paper2 = new Paper();

            var expected = 0;

            Assert.AreEqual(expected, paper1.Beats(paper2));
        }

    }
}
