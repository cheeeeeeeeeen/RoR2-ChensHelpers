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
        /// Adds an item into the list if the condition is met.
        /// This is just a combination for Add and Exists.
        /// </summary>
        /// <typeparam name="T">Type of the items in the list</typeparam>
        /// <param name="list">The list in question</param>
        /// <param name="value">The value to add into the list</param>
        /// <param name="condition">The condition check (itemFromTheList, valueToAdd)</param>
        /// <returns>True if the item is added. False if the item already exists.</returns>
        public static bool ConditionalAdd<T>(this List<T> list, T value, Func<T, T, bool> condition) 
        {
            if (list.Exists(item => condition(item, value))) return false;
            list.Add(value);
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
