
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./UticAwWcvUpoDr313GsfOg 'Chen.Helpers.UnityHelpers').[Extensions](./bNepnS8tqBl+9fIF99AuOA 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;) Method
An extension that allows fetching or adding a component.  
This overload contains post-processing logic of the component.  
Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject, System.Action<T> action);
```

#### Type parameters
<a name='MEJHNT4JSKa0Neke0oJuLQ'></a>
`T`  
  
  

#### Parameters
<a name='hFff9JOF1Dcy+kkOIk7oCQ'></a>
`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
  
  
<a name='XncgUpEIhsr78UvCeG19uA'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#MEJHNT4JSKa0Neke0oJuLQ 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
  

#### Returns
[T](#MEJHNT4JSKa0Neke0oJuLQ 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;).T')  
The component specified as T  
