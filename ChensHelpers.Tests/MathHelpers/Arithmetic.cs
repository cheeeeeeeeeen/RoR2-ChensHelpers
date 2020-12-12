using Chen.Helpers.MathHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chen.Helpers.Tests.MathHelpers
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SafeDivide_WithFloat_ReturnsQuotient()
        {
            const float dividend = 3f;
            const float divisor = 2f;
            const float expectation = 1.5f;

            float result = dividend.SafeDivide(divisor);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void SafeDivide_WithFloat_ReturnsFallbackValue()
        {
            const float dividend = 100f;
            const float divisor = 0f;
            const float fallback = 1.234f;
            const float expectation = 1.234f;

            float result = dividend.SafeDivide(divisor, fallback);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void SafeDivide_WithInteger_ReturnsQuotient()
        {
            const int dividend = 3;
            const int divisor = 2;
            const int expectation = 1;

            int result = dividend.SafeDivide(divisor);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void SafeDivide_WithInteger_ReturnsFallbackValue()
        {
            const int dividend = 3;
            const int divisor = 0;
            const int expectation = 0;

            int result = dividend.SafeDivide(divisor);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Sum_WithIntegers_ReturnsSummation()
        {
            int[] array = { 1, 2, 3, 4 };
            const int expectation = 10;

            int result = array.Sum();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Sum_PreProcessingIntegers_ReturnsSummation()
        {
            int[] array = { 1, 2, 3, 4 };
            const int expectation = 4;

            int result = array.Sum(item => 1);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Sum_WithFloats_ReturnsSummation()
        {
            float[] array = { 1.1f, 2.2f, 3.3f, 4.4f };
            const float expectation = 11f;

            float result = array.Sum();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Sum_PreProcessingFloats_ReturnsSummation()
        {
            float[] array = { 1.1f, 2.2f, 3.3f, 4.4f };
            const float expectation = 4.4f;

            float result = array.Sum(item => 1.1f);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Average_WithIntegers_ReturnsFloatAverage()
        {
            int[] array = { 10, 30 };
            const float expectation = 20f;

            float result = array.Average();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Average_PreProcessingIntegers_ReturnsFloatAverage()
        {
            int[] array = { 11, 31 };
            const float expectation = 20f;

            float result = array.Average(item => item - 1);

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Average_WithFloats_ReturnsFloatAverage()
        {
            float[] array = { .1f, .3f };
            const float expectation = .2f;

            float result = array.Average();

            Assert.AreEqual(expectation, result);
        }

        [TestMethod]
        public void Average_PreProcessingFloats_ReturnsFloatAverage()
        {
            float[] array = { 1.1f, 3.1f };
            const float expectation = 2f;

            float result = array.Average(item => item - .1f);

            Assert.AreEqual(expectation, result);
        }
    }
}