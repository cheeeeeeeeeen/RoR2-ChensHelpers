using System.Globalization;

namespace Chen.Helpers.MathHelpers
{
    /// <summary>
    /// Extensions related to percentages of numbers.
    /// </summary>
    public static class Percent
    {
        private static readonly int[] groupSize = new int[] { 3 };

        private static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            PercentPositivePattern = 1,
            PercentNegativePattern = 1,
            NegativeSign = "-",
            PercentSymbol = "%",
            PercentDecimalDigits = 0,
            PercentDecimalSeparator = ".",
            PercentGroupSeparator = "",
            PercentGroupSizes = groupSize,
            NumberNegativePattern = 1,
            NumberGroupSizes = groupSize,
            NumberGroupSeparator = "",
            NumberDecimalSeparator = ".",
            NumberDecimalDigits = 0
        };

        /// <summary>
        /// Converts the number into its percentage value.
        /// </summary>
        /// <param name="number">Number to convert from</param>
        /// <returns>Converted percentage value</returns>
        public static float ToPercent(this float number) => number * 100f;

        /// <summary>
        /// Converts the number into a string with control of the precision.
        /// </summary>
        /// <param name="number">Number to modify</param>
        /// <param name="precision">Precision to be followed</param>
        /// <returns>Formatted string of the number</returns>
        public static string ToPercent(this float number, uint precision)
        {
            return number.ToString($"P{precision}", numberFormatInfo);
        }

        /// <summary>
        /// Converts the percentage into its decimal value.
        /// </summary>
        /// <param name="percentage">Percentage to convert from</param>
        /// <returns>Converted decimal value</returns>
        public static float ToDecimal(this float percentage) => percentage / 100f;

        /// <summary>
        /// Converts the percentage into a string with control of the precision.
        /// </summary>
        /// <param name="percentage">Percentage to modify</param>
        /// <param name="precision">Precision to be followed</param>
        /// <returns>Formatted string of the percentage</returns>
        public static string ToDecimal(this float percentage, uint precision)
        {
            return percentage.ToDecimal().ToString($"N{precision}", numberFormatInfo);
        }
    }
}