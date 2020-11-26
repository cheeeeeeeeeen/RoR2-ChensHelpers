using BepInEx.Logging;

namespace Chen.Helpers.LogHelpers
{
    /// <summary>
    /// Helper class for logging.
    /// Its purpose is really to shorten the code when invoking it so that typing it would be fast and short.
    /// </summary>
    public class Log
    {
        private readonly ManualLogSource logger;

        /// <summary>
        /// Constructor for the Log helper. Always assign this to a variable with an internal access modifier to keep it to the calling assembly's scope.
        /// </summary>
        /// <param name="logger">BepInEx Logger object</param>
        public Log(ManualLogSource logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Log using the Debug format of BepInEx logger.
        /// </summary>
        /// <param name="data">Anything</param>
        public void Debug(object data) => logger.LogDebug(data);

        /// <summary>
        /// Log using the Error format of BepInEx logger.
        /// </summary>
        /// <param name="data">Anything</param>
        public void Error(object data) => logger.LogError(data);

        /// <summary>
        /// Log using the Info format of BepInEx logger.
        /// </summary>
        /// <param name="data">Anything</param>
        public void Info(object data) => logger.LogInfo(data);

        /// <summary>
        /// Log using the Message format of BepInEx logger.
        /// </summary>
        /// <param name="data">Anything</param>
        public void Message(object data) => logger.LogMessage(data);

        /// <summary>
        /// Log using the Warning format of BepInEx logger.
        /// </summary>
        /// <param name="data">Anything</param>
        public void Warning(object data) => logger.LogWarning(data);

        /// <summary>
        /// Log an array of values using Message format.
        /// </summary>
        /// <typeparam name="T">Type of the array</typeparam>
        /// <param name="data">Array of T</param>
        /// <param name="prefix">Prefix to be inserted before the data</param>
        public void Array<T>(T[] data, string prefix = "")
        {
            foreach (var datum in data)
            {
                Message($"{prefix}{datum}");
            }
        }
    }
}
