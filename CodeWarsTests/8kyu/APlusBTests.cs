using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestFixture]
    public class APlusBTests
    {
        [Test]
        public void TestSum()
        {
            byte a = 1;
            byte b = 2;
            Assert.That(APlusB.Sum(a, b), Is.EqualTo(3));
        }
    }
}
