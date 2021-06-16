#### [ChensHelpers](index 'index')
### [Chen.Helpers.CollectionHelpers](Chen_Helpers_CollectionHelpers 'Chen.Helpers.CollectionHelpers')
## Extensions Class
Useful extensions that relate to collection data structures.  
```csharp
public static class Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Extensions  

| Methods | |
| :--- | :--- |
| [ConditionalAdd&lt;T&gt;(List&lt;T&gt;, T, Func&lt;T,bool&gt;)](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAdd_T_(System_Collections_Generic_List_T__T_System_Func_T_bool_) 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;)') | Adds an item into the list if the condition is not met.<br/>This is just a combination for Add and Exists.<br/> |
| [ConditionalAddRange&lt;T&gt;(List&lt;T&gt;, T[], Func&lt;T,T,bool&gt;)](Chen_Helpers_CollectionHelpers_Extensions_ConditionalAddRange_T_(System_Collections_Generic_List_T__T___System_Func_T_T_bool_) 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAddRange&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T[], System.Func&lt;T,T,bool&gt;)') | Adds a range of values into the list. Each item will be processed from the data and will checked by the given condition.<br/>If the item matches the condition, it will not be added.<br/> |
| [ConditionalRemove&lt;T&gt;(List&lt;T&gt;, T)](Chen_Helpers_CollectionHelpers_Extensions_ConditionalRemove_T_(System_Collections_Generic_List_T__T) 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T)') | Removes the item from the list if it exists.<br/>This is just a combination for Contains and Remove.<br/> |
| [Contains&lt;T&gt;(T[], T)](Chen_Helpers_CollectionHelpers_Extensions_Contains_T_(T___T) 'Chen.Helpers.CollectionHelpers.Extensions.Contains&lt;T&gt;(T[], T)') | Checks if a value exists within the array.<br/> |
| [ToList&lt;T&gt;(T[])](Chen_Helpers_CollectionHelpers_Extensions_ToList_T_(T__) 'Chen.Helpers.CollectionHelpers.Extensions.ToList&lt;T&gt;(T[])') | Converts an array into their List counterpart.<br/> |
