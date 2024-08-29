using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// A helper that allows listening to function keys to generate pickup droplets in-game.
    /// Press F3 to generate a random white item (or essence).
    /// Press F4 to generate a random green item (or essence).
    /// Press F5 to generate a random red item (or essence).
    /// Press F6 to generate a random orange item (or essence).
    /// Press F7 to generate a random blue (both the item and equipment variants) item (or essence).
    /// Press F8 to generate a random yellow item (or essence).
    /// </summary>
    public static class DropletGenerator
    {
        /// <summary>
        /// Place this in a BaseUnityPlugin.Update() to enable the listeners.
        /// </summary>
        public static void Update()
        {
            var i3 = Input.GetKeyDown(KeyCode.F3);
            var i4 = Input.GetKeyDown(KeyCode.F4);
            var i5 = Input.GetKeyDown(KeyCode.F5);
            var i6 = Input.GetKeyDown(KeyCode.F6);
            var i7 = Input.GetKeyDown(KeyCode.F7);
            var i8 = Input.GetKeyDown(KeyCode.F8);
            var i9 = Input.GetKeyDown(KeyCode.F9);
            if (i3 || i4 || i5 || i6 || i7 || i8 || i9)
            {
                var t = Instances.hostBodyObject.transform;

                List<PickupIndex> spawnList;
                if (i3) spawnList = Run.instance.availableTier1DropList;
                else if (i4) spawnList = Run.instance.availableTier2DropList;
                else if (i5) spawnList = Run.instance.availableTier3DropList;
                else if (i6) spawnList = Run.instance.availableEquipmentDropList;
                else if (i7) spawnList = Run.instance.availableLunarItemDropList;
                else if (i8) spawnList = Run.instance.availableLunarEquipmentDropList;
                else spawnList = Run.instance.availableBossDropList;

                PickupDropletController.CreatePickupDroplet(
                    spawnList[Run.instance.spawnRng.RangeInt(0, spawnList.Count)],
                    t.position, new Vector3(0f, -5f, 0f)
                ); //I wont change this because im lazy, and pseudopulse already made a patcher for this specific method, so I'll just make that a dependency if its an absolute must
            }
        }
    }
}