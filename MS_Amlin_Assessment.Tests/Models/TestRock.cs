using MS_Amlin_Assessment.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Amlin_Assessment.Tests.Models
{
    class TestRock
    {
        [Test]
        public void TestShouldBeatScissors()
        {
            Rock rock = new Rock();
            Scissors scissors = new Scissors();

            var expected = 1;

            Assert.AreEqual(expected, rock.Beats(scissors));
        }

        [Test]
        public void TestShouldNotBeatPaper()
        {
            Rock rock = new Rock();
            Paper paper = new Paper();

            var expected = -1;

            Assert.AreEqual(expected, rock.Beats(paper));
        }

        [Test]
        public void TestShouldTieRock()
        {
            Rock rock1 = new Rock();
            Rock rock2 = new Rock();

            var expected = 0;

            Assert.AreEqual(expected, rock1.Beats(rock2));
        }
     
    }
}
