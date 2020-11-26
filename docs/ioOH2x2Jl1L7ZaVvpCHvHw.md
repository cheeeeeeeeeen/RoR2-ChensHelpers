
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./UticAwWcvUpoDr313GsfOg 'Chen.Helpers.UnityHelpers').[Extensions](./bNepnS8tqBl+9fIF99AuOA 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject) Method
An extension that allows fetching or adding a component.  
If the GameObject has the component, it will only fetch it and return the component.  
If the GameObject does not have the component, it will add one to it and return the component.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject);
```

#### Type parameters
<a name='vGTK5AmWto-tkFwNOu3dfQ'></a>
`T`  
A Unity Component  
  

#### Parameters
<a name='zPuQ+niyIBR6iigF04i4Zw'></a>
`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The GameObject to fetch from or add to  
  

#### Returns
[T](#vGTK5AmWto-tkFwNOu3dfQ 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject).T')  
The component specified as T  
