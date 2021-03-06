
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.CollectionHelpers](./Chen-Helpers-CollectionHelpers 'Chen.Helpers.CollectionHelpers').[Extensions](./Chen-Helpers-CollectionHelpers-Extensions 'Chen.Helpers.CollectionHelpers.Extensions')

## Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;) Method
Adds an item into the list if the condition is not met.  
This is just a combination for Add and Exists.  
```csharp
public static bool ConditionalAdd<T>(this System.Collections.Generic.List<T> list, T value, System.Func<T,bool> condition);
```

#### Type parameters
<a name='Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-T'></a>
`T`  
Type of the items in the list  
  

#### Parameters
<a name='Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-list'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](#Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The list in question  
  
<a name='Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-value'></a>
`value` [T](#Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')  
The value to add into the list  
  
<a name='Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#Chen-Helpers-CollectionHelpers-Extensions-ConditionalAdd-T-(System-Collections-Generic-List-T-_T_System-Func-T_bool-)-T 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The existence condition check where T is the item from the list  
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is added. False if the item already exists.  
