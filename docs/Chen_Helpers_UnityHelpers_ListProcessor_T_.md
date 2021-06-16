#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')
## ListProcessor&lt;T&gt; Class
A generic component for implementing a List Processor.  
The List Processor will attempt to process all the items in the data structure in a single frame.  
```csharp
public abstract class ListProcessor<T> : UnityEngine.MonoBehaviour
```
#### Type parameters
<a name='Chen_Helpers_UnityHelpers_ListProcessor_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; ListProcessor&lt;T&gt;  

| Fields | |
| :--- | :--- |
| [processList](Chen_Helpers_UnityHelpers_ListProcessor_T__processList 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.processList') | The data structure where all items are stored for processing.<br/> |

| Properties | |
| :--- | :--- |
| [processInterval](Chen_Helpers_UnityHelpers_ListProcessor_T__processInterval 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.processInterval') | The time gap in seconds in between processes.<br/> |
| [repeatUntilSuccess](Chen_Helpers_UnityHelpers_ListProcessor_T__repeatUntilSuccess 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.repeatUntilSuccess') | Determines whether the data structure should save failed items back and repeat the process in the same frame.<br/> |

| Methods | |
| :--- | :--- |
| [Add(T)](Chen_Helpers_UnityHelpers_ListProcessor_T__Add(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.Add(T)') | Adds an item into the data structure for processing. No need to override this, but one may do so for complex implementations.<br/> |
| [FixedUpdate()](Chen_Helpers_UnityHelpers_ListProcessor_T__FixedUpdate() 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.FixedUpdate()') | A method powered by Unity's MonoBehaviour. This contains the logic processing the queue and its items.<br/>There is no need to override this, however if complex code is required, one may do so.<br/> |
| [OnFailure(T)](Chen_Helpers_UnityHelpers_ListProcessor_T__OnFailure(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.OnFailure(T)') | A post-processing method to perform when the operation process failed. Always invoke base.OnFailure.<br/> |
| [OnSuccess(T)](Chen_Helpers_UnityHelpers_ListProcessor_T__OnSuccess(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.OnSuccess(T)') | A post-processing method to perform when the operation process is successful. Always invoke base.OnSuccess.<br/> |
| [Process(T)](Chen_Helpers_UnityHelpers_ListProcessor_T__Process(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.Process(T)') | A method the contains the main processing logic. It is required to be implemented by the child class.<br/>This method returns a boolean that determines the outcome of the item from the list.<br/>Returning true will dispose of the item. Returning false will put the item back at the end of the queue.<br/> |
