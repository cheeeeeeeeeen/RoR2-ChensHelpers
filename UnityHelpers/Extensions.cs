using System;
using UnityEngine;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// Extensions for Unity objects.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// An extension that allows fetching or adding a component.
        /// If the GameObject has the component, it will only fetch it and return the component.
        /// If the GameObject does not have the component, it will add one to it and return the component.
        /// </summary>
        /// <typeparam name="T">A Unity Component</typeparam>
        /// <param name="gameObject">The GameObject to fetch from or add to</param>
        /// <returns>The component specified as T</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if (!component) component = gameObject.AddComponent<T>();
            return component;
        }

        /// <summary>
        /// An extension that allows fetching or adding a component.
        /// This overload contains post-processing logic of the component.
        /// Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gameObject"></param>
        /// <param name="action"></param>
        /// <returns>The component specified as T</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject, Action<T> action) where T : Component
        {
            T component = gameObject.GetOrAddComponent<T>();
            action(component);
            return component;
        }

        /// <summary>
        /// An extension that allows fetching or adding a component.
        /// This overload contains post-processing logic of the component depending whether it was created or fetched.
        /// Only used for advanced logic without having to do an if-else statement after the method call.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gameObject"></param>
        /// <param name="getAction"></param>
        /// <param name="addAction"></param>
        /// <returns>The component specified as T</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject, Action<T> getAction, Action<T> addAction) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if (component) getAction(component);
            else
            {
                component = gameObject.AddComponent<T>();
                addAction(component);
            }
            return component;
        }
    }
}
