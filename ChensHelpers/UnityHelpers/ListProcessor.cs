using Chen.Helpers.CollectionHelpers;
using System.Collections.Generic;
using UnityEngine;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// A generic component for implementing a List Processor.
    /// The List Processor will attempt to process all the items in the data structure in a single frame.
    /// </summary>
    public abstract class ListProcessor<T> : MonoBehaviour
    {
        /// <summary>
        /// The data structure where all items are stored for processing.
        /// </summary>
        protected List<T> processList = new List<T>();

        /// <summary>
        /// Determines whether the data structure should save failed items back and repeat the process in the same frame.
        /// </summary>
        protected abstract bool repeatUntilSuccess { get; set; }

        /// <summary>
        /// The time gap in seconds in between processes.
        /// </summary>
        protected abstract float processInterval { get; set; }

        private float intervalTimer = 0f;
        private readonly List<T> failedItems = new List<T>();

        /// <summary>
        /// Adds an item into the data structure for processing. No need to override this, but one may do so for complex implementations.
        /// </summary>
        /// <param name="item">New item to add</param>
        /// <returns>True if the item is added. False if the item already exists.</returns>
        public virtual bool Add(T item)
        {
            return processList.ConditionalAdd(item, listItem => item.Equals(listItem));
        }

        /// <summary>
        /// A method the contains the main processing logic. It is required to be implemented by the child class.
        /// This method returns a boolean that determines the outcome of the item from the list.
        /// Returning true will dispose of the item. Returning false will put the item back at the end of the queue.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        /// <returns>Return true to send a signal of a successful processing, false otherwise.</returns>
        protected abstract bool Process(T item);

        /// <summary>
        /// A post-processing method to perform when the operation process is successful. Always invoke base.OnSuccess.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        protected virtual void OnSuccess(T item)
        {
        }

        /// <summary>
        /// A post-processing method to perform when the operation process failed. Always invoke base.OnFailure.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        protected virtual void OnFailure(T item)
        {
            if (repeatUntilSuccess) failedItems.Add(item);
        }

        /// <summary>
        /// A method powered by Unity's MonoBehaviour. This contains the logic processing the queue and its items.
        /// There is no need to override this, however if complex code is required, one may do so.
        /// </summary>
        protected virtual void FixedUpdate()
        {
            intervalTimer += Time.fixedDeltaTime;
            if (intervalTimer >= processInterval)
            {
                while (processList.Count > 0)
                {
                    foreach (T item in processList)
                    {
                        bool result = Process(item);
                        if (result) OnSuccess(item);
                        else OnFailure(item);
                    }
                    if (repeatUntilSuccess)
                    {
                        processList.Clear();
                        processList.AddRange(failedItems);
                    }
                    else break;
                }
                intervalTimer -= processInterval;
            }
        }
    }
}