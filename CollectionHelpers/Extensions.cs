using System;
using System.Collections.Generic;

namespace Chen.Helpers.CollectionHelpers
{
    /// <summary>
    /// Useful extensions that relate to collection data structures.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Adds an item into the list if the condition is not met.
        /// This is just a combination for Add and Exists.
        /// </summary>
        /// <typeparam name="T">Type of the items in the list</typeparam>
        /// <param name="list">The list in question</param>
        /// <param name="value">The value to add into the list</param>
        /// <param name="condition">The existence condition check where T is the item from the list</param>
        /// <returns>True if the item is added. False if the item already exists.</returns>
        public static bool ConditionalAdd<T>(this List<T> list, T value, Func<T, bool> condition) 
        {
            if (list.Exists(item => condition(item))) return false;
            list.Add(value);
            return true;
        }

        /// <summary>
        /// Removes the item from the list if it exists.
        /// This is just a combination for Contains and Remove.
        /// </summary>
        /// <typeparam name="T">Type of the items in the list</typeparam>
        /// <param name="list">The list in question</param>
        /// <param name="value">The value to remove from the list</param>
        /// <returns>True if the item is removed. False if the item does not exist.</returns>
        public static bool ConditionalRemove<T>(this List<T> list, T value)
        {
            if (!list.Contains(value)) return false;
            list.Remove(value);
            return true;
        }

        /// <summary>
        /// Checks if a value exists within the array.
        /// </summary>
        /// <typeparam name="T">Data type of the array</typeparam>
        /// <param name="array">The array to inspect</param>
        /// <param name="value">The value to check</param>
        /// <returns>True if the value exists in the array. False if not.</returns>
        public static bool Contains<T>(this T[] array, T value)
        {
            foreach (T item in array)
            {
                if (item.Equals(value)) return true;
            }
            return false;
        }
    }
}
