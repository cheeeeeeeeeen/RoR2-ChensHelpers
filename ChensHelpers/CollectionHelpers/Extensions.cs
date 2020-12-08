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
        /// Adds a range of values into the list. Each item will be processed from the data and will checked by the given condition.
        /// If the item matches the condition, it will not be added.
        /// </summary>
        /// <typeparam name="T">Type of the items in the list and the array</typeparam>
        /// <param name="list">The list in question</param>
        /// <param name="data">Array of values</param>
        /// <param name="condition">The existence condition check where
        /// the first T is the item from the list
        /// and the second T is the item from the data array</param>
        /// <returns>True if all items are added. False if an item was not added.
        /// Items that failed the existence check will still be added.</returns>
        public static bool ConditionalAddRange<T>(this List<T> list, T[] data, Func<T, T, bool> condition)
        {
            bool returnValue = true;
            foreach (T datum in data)
            {
                bool isAdded = list.ConditionalAdd(datum, item => condition(item, datum));
                if (returnValue && !isAdded) returnValue = false;
            }
            return returnValue;
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

        /// <summary>
        /// Converts an array into their List counterpart.
        /// </summary>
        /// <param name="array">The array to convert</param>
        /// <typeparam name="T">Data type of the array</typeparam>
        /// <returns>The List equivalent of the array.</returns>
        public static List<T> ToList<T>(this T[] array)
        {
            List<T> newList = new List<T>();
            newList.AddRange(array);
            return newList;
        }
    }
}