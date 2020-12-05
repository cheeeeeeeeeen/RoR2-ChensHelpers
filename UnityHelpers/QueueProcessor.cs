using System;
using System.Collections.Generic;
using UnityEngine;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// A generic component for implementing a Queue Processor.
    /// </summary>
    public abstract class QueueProcessor<T> : MonoBehaviour
    {
        /// <summary>
        /// The data structure where all items are queued in for processing.
        /// </summary>
        protected Queue<T> processQueue = new Queue<T>();

        /// <summary>
        /// A method the contains the main processing logic. It is required to be implemented by the child class.
        /// This method returns a boolean that determines the outcome of the item from the queue.
        /// Returning true will dispose of the item. Returning false will put the item back at the end of the queue.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        /// <returns>Return true to send a signal of a successful processing, false otherwise.</returns>
        protected abstract bool Process(T item);

        /// <summary>
        /// A post-processing method to perform when the operation process is successful.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        protected virtual void OnSuccess(T item)
        {
        }

        /// <summary>
        /// A post-processing method to perform when the operation process failed.
        /// </summary>
        /// <param name="item">Item that was dequeued from the list</param>
        protected virtual void OnFailure(T item)
        {
        }

        /// <summary>
        /// A method powered by Unity's MonoBehaviour. This contains the logic processing the queue and its items.
        /// There is no need to override this, however if complex code is required, one may do so.
        /// </summary>
        protected virtual void FixedUpdate()
        {
            if (processQueue.Count > 0)
            {
                T item = processQueue.Dequeue();
                bool outcome = Process(item);
                if (outcome) OnSuccess(item);
                else
                {
                    OnFailure(item);
                    processQueue.Enqueue(item);
                }
            }
        }
    }
}