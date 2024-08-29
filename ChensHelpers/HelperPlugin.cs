using BepInEx;
using Chen.Helpers.LogHelpers;
using R2API;
using R2API.Networking;
using R2API.Utils;
using static Chen.Helpers.GeneralHelpers.MinionExtensions;

namespace Chen.Helpers
{
    /// <summary>
    /// The mother plugin so that it can be depended on. It does nothing by itself, though.
    /// </summary>
    [BepInPlugin(ModGuid, ModName, ModVer)]
    [BepInDependency(R2API.R2API.PluginGUID, R2API.R2API.PluginVersion)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [R2APISubmoduleDependency(nameof(SoundAPI), nameof(NetworkingAPI))]
    public class HelperPlugin : BaseUnityPlugin
    {
        /// <summary>
        /// Mod version of the plugin. Useful for fetching the version dynamically when depending on it.
        /// </summary>
        public const string ModVer = "1.1.3";

        /// <summary>
        /// Mod name of the plugin.
        /// </summary>
        public const string ModName = "ChensHelpers";

        /// <summary>
        /// Mod GUID of the plugin. Useful for referencing this GUID of this mod without the need to look it up.
        /// </summary>
        public const string ModGuid = "com.Chen.ChensHelpers";

        internal static Log Log { get; private set; }

        private void Awake()
        {
            Log = new Log(Logger);

            NetworkingAPI.RegisterMessageType<SyncOwner>();
        }
    }
}