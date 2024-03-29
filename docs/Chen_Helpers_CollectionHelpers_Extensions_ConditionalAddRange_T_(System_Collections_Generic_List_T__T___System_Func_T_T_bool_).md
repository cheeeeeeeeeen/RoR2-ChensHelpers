#### [ChensHelpers](index 'index')
### [Chen.Helpers.CollectionHelpers](Chen_Helpers_CollectionHelpers 'Chen.Helpers.CollectionHelpers').[Extensions](Chen_Helpers_CollectionHelpers_Extensions 'Chen.Helpers.CollectionHelpers.Extensions')
## Extensions.ConditionalAddRange&lt;T&gt;(List&lt;T&gt;, T[], Func&lt;T,T,bool&gt;) Method
Adds a range of values into the list. Each item will be processed from the data and will checked by the given condition.  
If the item matches the condition, it will not be added.  
```csharp
public static bool ConditionalAddRange<T>(this System.Collections.Generic.List<T> list, T[] data, System.Func<T,T,bool> condition);
```
#### Type parameters
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_T'></a>
`T`  
Type of the items in the list and the array
  
#### Parameters
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_list'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T[], System.Func&lt;T,T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The list in question
  
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_data'></a>
`data` [T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T[], System.Func&lt;T,T,bool&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of values
  
<a name='Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T[], System.Func&lt;T,T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)#Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_)_T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T[], System.Func&lt;T,T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The existence condition check where  
            the first T is the item from the list  
            and the second T is the item from the data array
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if all items are added. False if an item was not added.  
            Items that failed the existence check will still be added.
