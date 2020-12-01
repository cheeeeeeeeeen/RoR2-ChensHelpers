using UnityEngine;
using System.Collections.Generic;
using Chen.Helpers.CollectionHelpers;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// A helper class that allows playing sounds easily with just the WWise Event ID and a Keybind.
    /// </summary>
    public class SoundPlayer
    {
        private readonly Dictionary<KeyCode, List<uint>> keybinds = new Dictionary<KeyCode, List<uint>>();
        
        /// <summary>
        /// Constructor to create an instance of the class.
        /// A group of EventPosterKeys may be passed as parameters to automatically register them.
        /// </summary>
        /// <param name="eventPosterKeys"></param>
        public SoundPlayer(params EventPosterKey[] eventPosterKeys)
        {
            foreach (EventPosterKey eventPosterKey in eventPosterKeys)
            {
                RegisterKeybind(eventPosterKey);
            }
        }

        /// <summary>
        /// Place this in a BaseUnityPlugin.Update() to enable the listeners for the keybinds registered.
        /// </summary>
        public void Update()
        {
            foreach (var keybind in keybinds)
            {
                bool isPressed = Input.GetKeyDown(keybind.Key);
                if (isPressed)
                {
                    foreach (uint eventId in keybind.Value)
                    {
                        AkSoundEngine.PostEvent(eventId, Instances.hostBodyObject);
                    }
                }
            }
        }

        /// <summary>
        /// Registers a keybind for a WWise Event that posts the event upon being pressed.
        /// Duplicated EventPosterKeys will be replaced by a later assignment.
        /// </summary>
        /// <param name="eventPosterKey"></param>
        public void RegisterKeybind(EventPosterKey eventPosterKey)
        {
            keybinds[eventPosterKey.key] = eventPosterKey.eventIds;
        }

        /// <summary>
        /// Registers a keybind for a WWise Event that posts the event upon being pressed.
        /// Duplicated EventPosterKeys will be replaced by a later assignment.
        /// Alternative overload that does not use the EVentPosterKey data structure.
        /// </summary>
        /// <param name="key">The key to be assigned</param>
        /// <param name="eventIds">Group of Event IDs</param>
        public void RegisterKeybind(KeyCode key, params uint[] eventIds)
        {
            keybinds[key] = eventIds.ToList();
        }

        /// <summary>
        /// Represents the data structure for a keybind that is responsible for posting WWise sound events.
        /// </summary>
        public struct EventPosterKey
        {
            /// <summary>
            /// The key which will be assigned to post Event IDs.
            /// </summary>
            public KeyCode key;

            /// <summary>
            /// List of Event IDs that will be posted when the assigned key is pressed.
            /// </summary>
            public List<uint> eventIds;

            /// <summary>
            /// Constructor for building the data for binding keys with assigned Event IDs.
            /// There may be duplicate Event IDs that can exist in one keybind.
            /// </summary>
            /// <param name="key">Key to be assigned to</param>
            /// <param name="eventIds">Group of Event IDs</param>
            public EventPosterKey(KeyCode key, params uint[] eventIds)
            {
                this.key = key;
                this.eventIds = new List<uint>();
                this.eventIds.AddRange(eventIds);
            }
        }
    }
}