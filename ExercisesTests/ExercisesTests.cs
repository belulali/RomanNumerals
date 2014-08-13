using Exercises;
using NUnit.Framework;

namespace ExercisesTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        RomanNumerals _romanNumerals;

        [SetUp]
        public void SetUp()
        {
            _romanNumerals = new RomanNumerals();
        }

        [Test]
        public void ShouldReturnIWhenGivenOne()
        {
            var transform = _romanNumerals.Transform(1);
            Assert.That(transform, Is.EqualTo("I"));
        }

        [Test]
        public void ShouldReturnIIWhenGivenTwo()
        {
            var transform = _romanNumerals.Transform(2);
            Assert.That(transform, Is.EqualTo("II"));
        }

        [Test]
        public void ShouldReturnIIIWhenGivenThree()
        {
            var transform = _romanNumerals.Transform(3);
            Assert.That(transform, Is.EqualTo("III"));
        }

        [Test]
        public void ShouldReturnIVWhenGivenFour()
        {
            var transform = _romanNumerals.Transform(4);
            Assert.That(transform, Is.EqualTo("IV"));
        }

        [Test]
        public void ShouldReturnVWhenGivenFive()
        {
            var transform = _romanNumerals.Transform(5);
            Assert.That(transform, Is.EqualTo("V"));
        }

        [Test]
        public void ShouldReturnLVIIIWhenGivenFiftyEight()
        {
            var transform = _romanNumerals.Transform(58);
            Assert.That(transform, Is.EqualTo("LVIII"));
        }

        [Test]
        public void ShouldReturnLCXLIWhenGivenOneHundredFourtyOne()
        {
            var transform = _romanNumerals.Transform(141);
            Assert.That(transform, Is.EqualTo("CXLI"));
        }

        public void ShouldReturnDCCLXXXIIWhenGivenSevenHundredEightyTwo()
        {
            var transform = _romanNumerals.Transform(782);
            Assert.That(transform, Is.EqualTo("DCCLXXXII"));
        }
    }
}
