using RoR2;
using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// Useful extensions related to Minions.
    /// </summary>
    public static class MinionExtensions
    {
        /// <summary>
        /// Loops through the minions and applies processing for each through an action.
        /// </summary>
        /// <param name="owner">Master of the minions</param>
        /// <param name="logic">Code to apply for each minion of the owner</param>
        public static void LoopMinions(this CharacterMaster owner, Action<CharacterMaster> logic)
        {
            MinionOwnership[] minionOwnerships = Object.FindObjectsOfType<MinionOwnership>();
            foreach (MinionOwnership minionOwnership in minionOwnerships)
            {
                if (minionOwnership && minionOwnership.ownerMaster && minionOwnership.ownerMaster == owner)
                {
                    CharacterMaster minion = minionOwnership.GetComponent<CharacterMaster>();
                    logic(minion);
                }
            }
        }

        /// <summary>
        /// Fetches all the minions of an owner and returns a list of the minions' component.
        /// </summary>
        /// <typeparam name="T">Component to match</typeparam>
        /// <param name="owner">Master of the minions</param>
        /// <returns>List of components of the minions</returns>
        public static List<T> GetAllMinionComponents<T>(this CharacterMaster owner) where T : Component
        {
            List<T> list = new List<T>();
            LoopMinions(owner, (minion) =>
            {
                T component = minion.gameObject.GetComponent<T>();
                if (component) list.Add(component);
            });
            return list;
        }
    }
}
