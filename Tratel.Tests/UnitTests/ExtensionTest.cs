using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratel.Common.Extensions;

namespace Tratel.Tests.UnitTests
{
    [TestFixture]
    public class ExtensionTestFixture
    {
        [TestCase(" cAn pErk ", "Can PERK")]
        [TestCase("MusTafa keMal AtatÜRK", "Mustafa Kemal ATATÜRK")]
        [TestCase("John f. kennedY", "John F. KENNEDY")]
        [TestCase(" ", "")]
        [TestCase("  ", "")]
        [TestCase("cAn", "CAN")]
        [TestCase("J J okocha", "J J OKOCHA")]
        [TestCase("Santos Jr . Neymar", "Santos Jr. NEYMAR")]
        [TestCase("Ben Kalender!", "Ben KALENDER")]
        [TestCase("Can@ Pe%rk", "Can PERK")]
        public void UnordinaryPersonName_ShouldBeFormalized(string input, string expectation)
        {
            var result = input.Formalize();
            Assert.That(result, Is.EqualTo(expectation));
        }
    }
}
