using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    public class DisemvowelTrollsTests
    {
        [TestCase("This website is for losers LOL!", "Ths wbst s fr lsrs LL!")]
        [TestCase("No offense but,\nYour writing is among the worst I've ever read", "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")]
        [TestCase("What are you, a communist?", "Wht r y,  cmmnst?")]
        public void FixedTests(string str, string expected)
        {
            Assert.That(DisemvowelTrolls.Disemvowel(str), Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(GenerateTestCases))]
        public string RandomTests(string str) => DisemvowelTrolls.Disemvowel(str);

        private static IEnumerable<TestCaseData> GenerateTestCases()
        {
            string ReferenceSolution(string refStr)
            {
                bool IsVowel(char c) => new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }.Contains(c);
                return new string(refStr.Where(c => !IsVowel(c)).ToArray());
            }
            var rnd = new Random();
            int RandomInt(int a, int b) => (int)(rnd.Next(b - a)) + a;
            var chars = "abcdefghijklmnopqrsruvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!,@#$%^&*()[]{};         ";
            char randomChar() => chars[RandomInt(0, chars.Length)];
            for (var i = 0; i < 100; ++i)
            {
                var str = new string(Enumerable.Range(0, RandomInt(20, 100)).Select(_ => randomChar()).ToArray());
                var expected = ReferenceSolution(str);
                yield return new TestCaseData(str).Returns(expected).SetDescription($"str = \"{str}\"");
            }
        }
    }
}
