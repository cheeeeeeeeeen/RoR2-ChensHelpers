using Chen.Helpers.MathHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chen.Helpers.Tests.MathHelpers
{
    [TestClass]
    public class Percent
    {
        [TestMethod]
        public void ToPercent_Conversion_ReturnsPercentEquivalent()
        {
            const float decimalValue = .03f;
            const float expectation = 3f;

            float result = decimalValue.ToPercent();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void ToPercent_ToString_ReturnsPercentFormat()
        {
            const float decimalValue = .03f;
            const string expectation = "3%";

            string result = decimalValue.ToPercent(0);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void ToDecimal_Conversion_ReturnsDecimalEquivalent()
        {
            const float percentValue = 40f;
            const float expectation = .4f;

            float result = percentValue.ToDecimal();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void ToDecimal_ToString_ReturnsDecimalFormat()
        {
            const float percentValue = 40f;
            const string expectation = "0.4000";

            string result = percentValue.ToDecimal(4);

            Assert.AreEqual(expectation, result);
        }
    }
}