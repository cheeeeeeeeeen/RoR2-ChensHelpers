#### [ChensHelpers](index 'index')
### [Chen.Helpers.CollectionHelpers](Chen_Helpers_CollectionHelpers 'Chen.Helpers.CollectionHelpers').[Extensions](Chen_Helpers_CollectionHelpers_Extensions 'Chen.Helpers.CollectionHelpers.Extensions')
## Extensions.ConditionalRemove&lt;T&gt;(List&lt;T&gt;, T) Method
Removes the item from the list if it exists.  
This is just a combination for Contains and Remove.  
```csharp
public static bool ConditionalRemove<T>(this System.Collections.Generic.List<T> list, T value);
```
#### Type parameters
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)_T'></a>
`T`  
Type of the items in the list
  
#### Parameters
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)_list'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The list in question
  
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)_value'></a>
`value` [T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T).T')  
The value to remove from the list
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is removed. False if the item does not exist.
