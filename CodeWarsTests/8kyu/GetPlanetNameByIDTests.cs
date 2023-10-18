using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetPlanetNameByIDTests
    {
        [Test]
        public void Test()
        {
            Assert.Multiple(() =>
            {
                Assert.That(GetPlanetNameByID.GetPlanetName(2), Is.EqualTo("Venus"));
                Assert.That(GetPlanetNameByID.GetPlanetName(5), Is.EqualTo("Jupiter"));
            });
        }
    }
}
