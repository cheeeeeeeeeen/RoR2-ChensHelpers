
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./UticAwWcvUpoDr313GsfOg 'Chen.Helpers.UnityHelpers').[Extensions](./bNepnS8tqBl+9fIF99AuOA 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;) Method
An extension that allows fetching or adding a component.  
This overload contains post-processing logic of the component depending whether it was created or fetched.  
Only used for advanced logic without having to do an if-else statement after the method call.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject, System.Action<T> getAction, System.Action<T> addAction);
```

#### Type parameters
<a name='jq03p-X-mNMANi6Uwg7O1w'></a>
`T`  
  
  

#### Parameters
<a name='BgqG-p6P8AkopJJO4NUsMw'></a>
`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
  
  
<a name='rRWmK3yaYFVKhg6oWEQJMg'></a>
`getAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#jq03p-X-mNMANi6Uwg7O1w 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
  
<a name='VMqkjkntFwGYdhzuf9Evdw'></a>
`addAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#jq03p-X-mNMANi6Uwg7O1w 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
  

#### Returns
[T](#jq03p-X-mNMANi6Uwg7O1w 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')  
The component specified as T  
