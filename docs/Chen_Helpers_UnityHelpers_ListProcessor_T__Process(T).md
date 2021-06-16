
#### [ChensHelpers](index 'index')

### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[ListProcessor&lt;T&gt;](Chen_Helpers_UnityHelpers_ListProcessor_T_ 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;')

## ListProcessor&lt;T&gt;.Process(T) Method
A method the contains the main processing logic. It is required to be implemented by the child class.  
This method returns a boolean that determines the outcome of the item from the list.  
Returning true will dispose of the item. Returning false will put the item back at the end of the queue.  
```csharp
protected abstract bool Process(T item);
```

#### Parameters
<a name='Chen_Helpers_UnityHelpers_ListProcessor_T__Process(T)_item'></a>
`item` [T](Chen_Helpers_UnityHelpers_ListProcessor_T_#Chen_Helpers_UnityHelpers_ListProcessor_T__T 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.T')  
Item that was dequeued from the list
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Return true to send a signal of a successful processing, false otherwise.
