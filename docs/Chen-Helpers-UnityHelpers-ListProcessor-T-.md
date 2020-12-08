
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers')

## ListProcessor&lt;T&gt; Class
A generic component for implementing a List Processor.  
The List Processor will attempt to process all the items in the data structure in a single frame.  
```csharp
public abstract class ListProcessor<T> : MonoBehaviour
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; ListProcessor&lt;T&gt;  

#### Type parameters
<a name='Chen-Helpers-UnityHelpers-ListProcessor-T--T'></a>
`T`  
  

### Fields
- [processList](./Chen-Helpers-UnityHelpers-ListProcessor-T--processList 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.processList')

### Properties
- [processInterval](./Chen-Helpers-UnityHelpers-ListProcessor-T--processInterval 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.processInterval')
- [repeatUntilSuccess](./Chen-Helpers-UnityHelpers-ListProcessor-T--repeatUntilSuccess 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.repeatUntilSuccess')

### Methods
- [Add(T)](./Chen-Helpers-UnityHelpers-ListProcessor-T--Add(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.Add(T)')
- [FixedUpdate()](./Chen-Helpers-UnityHelpers-ListProcessor-T--FixedUpdate() 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.FixedUpdate()')
- [OnFailure(T)](./Chen-Helpers-UnityHelpers-ListProcessor-T--OnFailure(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.OnFailure(T)')
- [OnSuccess(T)](./Chen-Helpers-UnityHelpers-ListProcessor-T--OnSuccess(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.OnSuccess(T)')
- [Process(T)](./Chen-Helpers-UnityHelpers-ListProcessor-T--Process(T) 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.Process(T)')
