using NUnit.Framework;

namespace DigitalNumbetConverToRomanNumber
{
    [TestFixture()]
    public class DigitalToRomanConvertTest
    {
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(7, ExpectedResult = "VII")]
        [TestCase(8, ExpectedResult = "VIII")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(39, ExpectedResult = "XXXIX")]
        [TestCase(3999, ExpectedResult = "MMMCMXCIX")]
        public string InputShouldBe(int input)
        {
            var target = new DigitalToRomanConvert();
            return target.Convert(input);
        }
    }
}