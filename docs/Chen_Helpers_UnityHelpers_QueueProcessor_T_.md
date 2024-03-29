#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')
## QueueProcessor&lt;T&gt; Class
A generic component for implementing a Queue Processor.  
The Queue Processor attempts to process N items per frame, allowing items to be processed over time and not instantaneously.  
```csharp
public abstract class QueueProcessor<T>
```
#### Type parameters
<a name='Chen_Helpers_UnityHelpers_QueueProcessor_T__T'></a>
`T`  
  

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; QueueProcessor&lt;T&gt;  

| Fields | |
| :--- | :--- |
| [processQueue](Chen_Helpers_UnityHelpers_QueueProcessor_T__processQueue 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.processQueue') | The data structure where all items are queued in for processing.<br/> |

| Properties | |
| :--- | :--- |
| [itemsPerFrame](Chen_Helpers_UnityHelpers_QueueProcessor_T__itemsPerFrame 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.itemsPerFrame') | Number of items to process per frame.<br/> |
| [processInterval](Chen_Helpers_UnityHelpers_QueueProcessor_T__processInterval 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.processInterval') | The time gap in seconds in between processes.<br/> |

| Methods | |
| :--- | :--- |
| [Add(T)](Chen_Helpers_UnityHelpers_QueueProcessor_T__Add(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.Add(T)') | Adds an item into the data structure for processing. No need to override this, but one may do so for complex implementations.<br/> |
| [FixedUpdate()](Chen_Helpers_UnityHelpers_QueueProcessor_T__FixedUpdate() 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.FixedUpdate()') | A method powered by Unity's MonoBehaviour. This contains the logic processing the queue and its items.<br/>There is no need to override this, however if complex code is required, one may do so.<br/> |
| [OnFailure(T)](Chen_Helpers_UnityHelpers_QueueProcessor_T__OnFailure(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.OnFailure(T)') | A post-processing method to perform when the operation process failed. Always invoke base.OnFailure.<br/> |
| [OnSuccess(T)](Chen_Helpers_UnityHelpers_QueueProcessor_T__OnSuccess(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.OnSuccess(T)') | A post-processing method to perform when the operation process is successful. Always invoke base.OnSuccess.<br/> |
| [Process(T)](Chen_Helpers_UnityHelpers_QueueProcessor_T__Process(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.Process(T)') | A method the contains the main processing logic. It is required to be implemented by the child class.<br/>This method returns a boolean that determines the outcome of the item from the queue.<br/>Returning true will dispose of the item. Returning false will put the item back at the end of the queue.<br/> |
