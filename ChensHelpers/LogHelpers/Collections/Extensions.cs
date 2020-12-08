using System;

namespace Chen.Helpers.LogHelpers.Collections
{
    /// <summary>
    /// Extensions for Log to allow logging with collections of data with ease.
    /// </summary>
    public static class Extensions
    {
        private const string defaultToken = "%DATA%";

        /// <summary>
        /// Logs an array of values using the Message format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.
        /// The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).
        /// e.g. MessageArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:
        /// -> Chen..!
        /// -> is..!
        /// -> AWESOME..!
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="format">The format that will be outputted per item, with the item represented as %DATA%
        /// (can be overridden through representation parameter)</param>
        /// <param name="representation">Token that will be used as the item when parsing the format</param>
        public static void MessageArray<T>(this Log logger, T[] data, string format = defaultToken, string representation = defaultToken)
        {
            GenericLogging(data, format, representation, item => logger.Message(item));
        }

        /// <summary>
        /// Logs an array of values using the Message format. Use code logic to control the format directly.
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="formatter">Logic formatter where T is the item for use</param>
        public static void MessageArray<T>(this Log logger, T[] data, Func<T, string> formatter)
        {
            GenericLogging(data, formatter, formatted => logger.Message(formatted));
        }

        /// <summary>
        /// Logs an array of values using the Info format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.
        /// The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).
        /// e.g. InfoArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:
        /// -> Chen..!
        /// -> is..!
        /// -> AWESOME..!
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="format">The format that will be outputted per item, with the item represented as %DATA%
        /// (can be overridden through representation parameter)</param>
        /// <param name="representation">Token that will be used as the item when parsing the format</param>
        public static void InfoArray<T>(this Log logger, T[] data, string format = defaultToken, string representation = defaultToken)
        {
            GenericLogging(data, format, representation, item => logger.Info(item));
        }

        /// <summary>
        /// Logs an array of values using the Info format. Use code logic to control the format directly.
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="formatter">Logic formatter where T is the item for use</param>
        public static void InfoArray<T>(this Log logger, T[] data, Func<T, string> formatter)
        {
            GenericLogging(data, formatter, formatted => logger.Info(formatted));
        }

        /// <summary>
        /// Logs an array of values using the Warning format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.
        /// The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).
        /// e.g. WarningArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:
        /// -> Chen..!
        /// -> is..!
        /// -> AWESOME..!
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="format">The format that will be outputted per item, with the item represented as %DATA%
        /// (can be overridden through representation parameter)</param>
        /// <param name="representation">Token that will be used as the item when parsing the format</param>
        public static void WarningArray<T>(this Log logger, T[] data, string format = defaultToken, string representation = defaultToken)
        {
            GenericLogging(data, format, representation, item => logger.Warning(item));
        }

        /// <summary>
        /// Logs an array of values using the Warning format. Use code logic to control the format directly.
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="formatter">Logic formatter where T is the item for use</param>
        public static void WarningArray<T>(this Log logger, T[] data, Func<T, string> formatter)
        {
            GenericLogging(data, formatter, formatted => logger.Warning(formatted));
        }

        /// <summary>
        /// Logs an array of values using the Error format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.
        /// The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).
        /// e.g. ErrorArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:
        /// -> Chen..!
        /// -> is..!
        /// -> AWESOME..!
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="format">The format that will be outputted per item, with the item represented as %DATA%
        /// (can be overridden through representation parameter)</param>
        /// <param name="representation">Token that will be used as the item when parsing the format</param>
        public static void ErrorArray<T>(this Log logger, T[] data, string format = defaultToken, string representation = defaultToken)
        {
            GenericLogging(data, format, representation, item => logger.Error(item));
        }

        /// <summary>
        /// Logs an array of values using the Error format. Use code logic to control the format directly.
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="formatter">Logic formatter where T is the item for use</param>
        public static void ErrorArray<T>(this Log logger, T[] data, Func<T, string> formatter)
        {
            GenericLogging(data, formatter, formatted => logger.Error(formatted));
        }

        /// <summary>
        /// Logs an array of values using the Debug format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.
        /// The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).
        /// e.g. DebugArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:
        /// -> Chen..!
        /// -> is..!
        /// -> AWESOME..!
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="format">The format that will be outputted per item, with the item represented as %DATA%
        /// (can be overridden through representation parameter)</param>
        /// <param name="representation">Token that will be used as the item when parsing the format</param>
        public static void DebugArray<T>(this Log logger, T[] data, string format = defaultToken, string representation = defaultToken)
        {
            GenericLogging(data, format, representation, item => logger.Debug(item));
        }

        /// <summary>
        /// Logs an array of values using the Debug format. Use code logic to control the format directly.
        /// </summary>
        /// <typeparam name="T">Type of data in the array</typeparam>
        /// <param name="logger">Log instance</param>
        /// <param name="data">The array</param>
        /// <param name="formatter">Logic formatter where T is the item for use</param>
        public static void DebugArray<T>(this Log logger, T[] data, Func<T, string> formatter)
        {
            GenericLogging(data, formatter, formatted => logger.Debug(formatted));
        }

        private static void GenericLogging<T>(T[] data, string format, string token, Action<string> logAction)
        {
            foreach (T datum in data)
            {
                string entry = "";
                string[] tokenized = format.Split(new string[] { token }, StringSplitOptions.None);
                int length = tokenized.Length;
                for (int i = 0; i < length; i++)
                {
                    entry += tokenized[i];
                    if (i != length - 1) entry += datum.ToString();
                }
                logAction(entry);
            }
        }

        private static void GenericLogging<T>(T[] data, Func<T, string> formatter, Action<string> logAction)
        {
            foreach (T datum in data) logAction(formatter(datum));
        }
    }
}