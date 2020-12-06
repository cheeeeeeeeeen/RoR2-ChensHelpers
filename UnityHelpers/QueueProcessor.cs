using System.Collections.Generic;
using UnityEngine;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// A generic component for implementing a Queue Processor.
    /// The Queue Processor attempts to process N items per frame, allowing items to be processed over time and not instantaneously.
    /// </summary>
    public abstract class QueueProcessor<T> : MonoBehaviour
    {
        /// <summary>
        /// The data structure where all items are queued in for processing.
        /// </summary>
        protected Queue<T> processQueue = new Queue<T>();

        /// <summary>
        /// Number of items to process per frame.
        /// </summary>
        protected abstract int itemsPerFrame { get; set; }

        /// <summary>
        /// Adds an item into the data structure for processing. No need to override this, but one may do so for complex implementations.
        /// </summary>
        /// <param name="item">New item to add</param>
        public virtual void Add(T item)
        {
            processQueue.Enqueue(item);
        }

        /// <summary>
        /// A method the contains the main processing logic. It is required to be implemented by the child class.
        /// This method returns a boolean that determines the outcome of the item from the queue.
        /// Returning true will dispose of the item. Returning false will put the item back at the end of the queue.
        /// </summary>
        /// <param name="item">Item that was dequeued from the data structure</param>
        /// <returns>Return true to send a signal of a successful processing, false otherwise.</returns>
        protected abstract bool Process(T item);

        /// <summary>
        /// A post-processing method to perform when the operation process is successful. Always invoke base.OnSuccess.
        /// </summary>
        /// <param name="item">Item that was dequeued from the data structure</param>
        protected virtual void OnSuccess(T item)
        {
        }

        /// <summary>
        /// A post-processing method to perform when the operation process failed. Always invoke base.OnFailure.
        /// </summary>
        /// <param name="item">Item that was dequeued from the data structure</param>
        protected virtual void OnFailure(T item)
        {
        }

        /// <summary>
        /// A method powered by Unity's MonoBehaviour. This contains the logic processing the queue and its items.
        /// There is no need to override this, however if complex code is required, one may do so.
        /// </summary>
        protected virtual void FixedUpdate()
        {
            for (int i = 0; i < itemsPerFrame; i++)
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
                else break;
            }
        }
    }
}