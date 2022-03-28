using BepInEx.Logging;
using Chen.Helpers.LogHelpers;
using RoR2.Networking;
using UnityEngine.Networking;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// A helper that can enable and disable Multiplayer Testing. Be sure to not enable this in Awake of a mod on release.
    /// </summary>
    public static class MultiplayerTest
    {
        private const string defaultEnableMessage = "Multiplayer Testing is enabled! If you see this message, report this as a bug to the mod developer!";
        private const string defaultDisableMessage = "Multiplayer Testing disabled.";

        private static void OnClientConnect(On.RoR2.Networking.NetworkManagerSystem.orig_OnClientConnect orig, NetworkManagerSystem self, NetworkConnection conn)
        {
        }

        private static void Enable()
        {
            On.RoR2.Networking.NetworkManagerSystem.OnClientConnect += OnClientConnect;
        }

        private static void Disable()
        {
            On.RoR2.Networking.NetworkManagerSystem.OnClientConnect -= OnClientConnect;
        }

        /// <summary>
        /// Enables Multiplayer Testing so that the mod creator can connect using two instances of the game.
        /// </summary>
        /// <param name="logger">BepInEx logger instance</param>
        /// <param name="message">Message to display when Multiplayer Testing is enabled</param>
        public static void Enable(ManualLogSource logger, string message = defaultEnableMessage)
        {
            if (logger != null) logger.LogWarning(message);
            Enable();
        }

        /// <summary>
        /// Enables Multiplayer Testing so that the mod creator can connect using two instances of the game.
        /// </summary>
        /// <param name="logger">LogHelpers.Log instance</param>
        /// <param name="message">Message to display when Multiplayer Testing is enabled</param>
        public static void Enable(Log logger, string message = defaultEnableMessage)
        {
            if (logger != null) logger.Warning(message);
            Enable();
        }

        /// <summary>
        /// Disables Multiplayer Testing.
        /// </summary>
        /// <param name="logger">BepInEx logger instance</param>
        /// <param name="message">Message to display when Multiplayer Testing is disabled</param>
        public static void Disable(ManualLogSource logger, string message = defaultDisableMessage)
        {
            if (logger != null) logger.LogWarning(message);
            Disable();
        }

        /// <summary>
        /// Disables Multiplayer Testing.
        /// </summary>
        /// <param name="logger">LogHelpers.Log instance</param>
        /// <param name="message">Message to display when Multiplayer Testing is disabled</param>
        public static void Disable(Log logger, string message = defaultDisableMessage)
        {
            if (logger != null) logger.Warning(message);
            Disable();
        }
    }
}