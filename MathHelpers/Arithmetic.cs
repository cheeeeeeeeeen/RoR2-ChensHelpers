using System;

namespace Chen.Helpers.MathHelpers
{
    /// <summary>
    /// Extensions related to computations involving numbers.
    /// </summary>
    public static class Arithmetic
    {
        /// <summary>
        /// Performs division with a safety check when the divisor is 0.
        /// The parameter fallbackResult will be returned instead if the divisor is 0.
        /// </summary>
        /// <param name="dividend">The number being divided</param>
        /// <param name="divisor">The number that will divide the dividend</param>
        /// <param name="fallbackResult">Return value if the divisor is 0</param>
        /// <returns>The quotient or the fallbackResult</returns>
        public static float SafeDivide(this float dividend, float divisor, float fallbackResult = float.PositiveInfinity)
        {
            if (divisor == 0) return fallbackResult;
            return dividend / divisor;
        }

        /// <summary>
        /// Performs division with a safety check when the divisor is 0.
        /// The parameter fallbackResult will be returned instead if the divisor is 0.
        /// </summary>
        /// <param name="dividend">The number being divided</param>
        /// <param name="divisor">The number that will divide the dividend</param>
        /// <param name="fallbackResult">Return value if the divisor is 0</param>
        /// <returns>The quotient or the fallbackResult</returns>
        public static int SafeDivide(this int dividend, int divisor, int fallbackResult = 0)
        {
            if (divisor == 0) return fallbackResult;
            return dividend / divisor;
        }

        /// <summary>
        /// Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.
        /// e.g. Sum(new int[] { 2, -4, 1 }, item => Mathf.Max(0, item)) will yield a result of 3.
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="preProcess">Preprocessor code</param>
        /// <returns>Sum of the values in the array</returns>
        public static int Sum(this int[] numbers, Func<int, int> preProcess = null)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                int processed;
                if (preProcess == null) processed = number;
                else processed = preProcess(number);
                sum += processed;
            }
            return sum;
        }

        /// <summary>
        /// Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.
        /// e.g. Sum(new float[] { 2f, -4f, 1f }, item => Mathf.Max(0f, item)) will yield a result of 3f.
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="preProcess">Preprocessor code</param>
        /// <returns>Sum of the values in the array</returns>
        public static float Sum(this float[] numbers, Func<float, float> preProcess = null)
        {
            float sum = 0;
            foreach (float number in numbers)
            {
                float processed;
                if (preProcess == null) processed = number;
                else processed = preProcess(number);
                sum += processed;
            }
            return sum;
        }

        /// <summary>
        /// Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.
        /// e.g. Average(new int[] { 2, -4, 2 }, item => Mathf.Max(2, item)) will yield a result of 2.
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="preProcess">Preprocessor code</param>
        /// <returns>Average of the values in the array</returns>
        /// <exception cref="DivideByZeroException">Raised when the array length is 0 when division is performed.</exception>
        public static int Average(this int[] numbers, Func<int, int> preProcess = null)
        {
            return Sum(numbers, preProcess) / numbers.Length;
        }

        /// <summary>
        /// Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.
        /// e.g. Average(new float[] { 2f, -4f, 2f }, item => Mathf.Max(2f, item)) will yield a result of 2f.
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="preProcess">Preprocessor code</param>
        /// <returns>Average of the values in the array</returns>
        /// <exception cref="DivideByZeroException">Raised when the array length is 0 when division is performed.</exception>
        public static float Average(this float[] numbers, Func<float, float> preProcess = null)
        {
            return Sum(numbers, preProcess) / numbers.Length;
        }
    }
}