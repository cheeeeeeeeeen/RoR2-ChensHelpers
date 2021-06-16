
#### [ChensHelpers](index 'index')

### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[ListProcessor&lt;T&gt;](Chen_Helpers_UnityHelpers_ListProcessor_T_ 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;')

## ListProcessor&lt;T&gt;.Add(T) Method
Adds an item into the data structure for processing. No need to override this, but one may do so for complex implementations.  
```csharp
public virtual bool Add(T item);
```

#### Parameters
<a name='Chen_Helpers_UnityHelpers_ListProcessor_T__Add(T)_item'></a>
`item` [T](Chen_Helpers_UnityHelpers_ListProcessor_T_#Chen_Helpers_UnityHelpers_ListProcessor_T__T 'Chen.Helpers.UnityHelpers.ListProcessor&lt;T&gt;.T')  
New item to add
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is added. False if the item already exists.
