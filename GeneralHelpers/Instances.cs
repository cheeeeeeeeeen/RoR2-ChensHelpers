using RoR2;
using UnityEngine;
using static Chen.Helpers.HelperPlugin;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// Helper static class that allows the fetching of an instance without the need to write long codes.
    /// Checks are done by this helper and should output a debug log in the console.
    /// </summary>
    public static class Instances
    {
        /// <summary>
        /// Gets the instance of the host's PlayerCharacterMasterController.
        /// </summary>
        public static PlayerCharacterMasterController hostPcmc
        {
            get
            {
                var instance = PlayerCharacterMasterController.instances[0];
                if (!instance) Log.Debug("hostPcmc is null");
                return instance;
            }
        }

        /// <summary>
        /// Gets the instance of the host's CharacterMaster component.
        /// </summary>
        public static CharacterMaster hostMaster
        {
            get
            {
                CharacterMaster instance = null;
                if (hostPcmc) instance = hostPcmc.master;
                if (!instance) Log.Debug("hostMaster is null");
                return instance;
            }
        }
        
        /// <summary>
        /// Gets the instance of the host's CharacterMaster GameObject.
        /// </summary>
        public static GameObject hostMasterObject
        {
            get
            {
                GameObject instance = null;
                if (hostMaster) instance = hostMaster.gameObject;
                return instance;
            }
        }

        /// <summary>
        /// Gets the instance of the host's CharacterBody component.
        /// </summary>
        public static CharacterBody hostBody
        {
            get
            {
                CharacterBody instance = null;
                if (hostMaster) instance = hostMaster.GetBody();
                if (!instance) Log.Debug("hostBody is null");
                return instance;
            }
        }

        /// <summary>
        /// Gets the instance of the host's CharacterBody GameObject.
        /// </summary>
        public static GameObject hostBodyObject
        {
            get
            {
                GameObject instance = null;
                if (hostBody) instance = hostBody.gameObject;
                return instance;
            }
        }
    }
}