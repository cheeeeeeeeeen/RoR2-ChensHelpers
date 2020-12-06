
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers')

## QueueProcessor&lt;T&gt; Class
A generic component for implementing a Queue Processor.  
The Queue Processor attempts to process N items per frame, allowing items to be processed over time and not instantaneously.  
```csharp
public abstract class QueueProcessor<T> : MonoBehaviour
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; QueueProcessor&lt;T&gt;  

#### Type parameters
<a name='Chen-Helpers-UnityHelpers-QueueProcessor-T--T'></a>
`T`  
  

### Fields
- [processQueue](./Chen-Helpers-UnityHelpers-QueueProcessor-T--processQueue 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.processQueue')

### Properties
- [itemsPerFrame](./Chen-Helpers-UnityHelpers-QueueProcessor-T--itemsPerFrame 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.itemsPerFrame')

### Methods
- [Add(T)](./Chen-Helpers-UnityHelpers-QueueProcessor-T--Add(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.Add(T)')
- [FixedUpdate()](./Chen-Helpers-UnityHelpers-QueueProcessor-T--FixedUpdate() 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.FixedUpdate()')
- [OnFailure(T)](./Chen-Helpers-UnityHelpers-QueueProcessor-T--OnFailure(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.OnFailure(T)')
- [OnSuccess(T)](./Chen-Helpers-UnityHelpers-QueueProcessor-T--OnSuccess(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.OnSuccess(T)')
- [Process(T)](./Chen-Helpers-UnityHelpers-QueueProcessor-T--Process(T) 'Chen.Helpers.UnityHelpers.QueueProcessor&lt;T&gt;.Process(T)')
