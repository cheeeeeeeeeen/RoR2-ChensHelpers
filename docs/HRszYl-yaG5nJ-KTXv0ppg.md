
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.CollectionHelpers](./DwHbUVbrAWB47BrJd2O1Ng 'Chen.Helpers.CollectionHelpers').[Extensions](./SY98pRtkb05-xncR8ottww 'Chen.Helpers.CollectionHelpers.Extensions')

## Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;) Method
Adds an item into the list if the condition is met.  
This is just a combination for Add and Exists.  
```csharp
public static bool ConditionalAdd<T>(this System.Collections.Generic.List<T> list, T value, System.Func<T,bool> condition);
```

#### Type parameters
<a name='CLVUBkckycRKNYk4P440BQ'></a>
`T`  
Type of the items in the list  
  

#### Parameters
<a name='myn4QJWz1m83e2TJ5Oo2BA'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](#CLVUBkckycRKNYk4P440BQ 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The list in question  
  
<a name='BnR8zbgTpR28xLcoY-HpZA'></a>
`value` [T](#CLVUBkckycRKNYk4P440BQ 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')  
The value to add into the list  
  
<a name='siGFT6mi6EmXZbpu4qya6g'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#CLVUBkckycRKNYk4P440BQ 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalAdd&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T, System.Func&lt;T,bool&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The condition check where T is the item from the list  
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is added. False if the item already exists.  
