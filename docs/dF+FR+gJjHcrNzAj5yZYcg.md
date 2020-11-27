
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.CollectionHelpers](./DwHbUVbrAWB47BrJd2O1Ng 'Chen.Helpers.CollectionHelpers').[Extensions](./SY98pRtkb05-xncR8ottww 'Chen.Helpers.CollectionHelpers.Extensions')

## Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T) Method
Removes the item from the list if it exists.  
This is just a combination for Contains and Remove.  
```csharp
public static bool ConditionalRemove<T>(this System.Collections.Generic.List<T> list, T value);
```

#### Type parameters
<a name='jWzzkiHAQ67kKrQXLcBgRQ'></a>
`T`  
Type of the items in the list  
  

#### Parameters
<a name='jEPFIR98SGoPHWiz2QxzKg'></a>
`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](#jWzzkiHAQ67kKrQXLcBgRQ 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The list in question  
  
<a name='ZGOgnnaroRu0jru3+VkVzw'></a>
`value` [T](#jWzzkiHAQ67kKrQXLcBgRQ 'Chen.Helpers.CollectionHelpers.Extensions.ConditionalRemove&lt;T&gt;(System.Collections.Generic.List&lt;T&gt;, T).T')  
The value to remove from the list  
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is removed. False if the item does not exist.  
