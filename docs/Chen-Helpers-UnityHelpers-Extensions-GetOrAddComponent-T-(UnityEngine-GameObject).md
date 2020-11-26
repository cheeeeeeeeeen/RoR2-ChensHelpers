#### [ChensHelpers](./index 'index')
### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](./Chen-Helpers-UnityHelpers-Extensions 'Chen.Helpers.UnityHelpers.Extensions')
## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject) Method
An extension that allows fetching or adding a component.  
If the GameObject has the component, it will only fetch it and return the component.  
If the GameObject does not have the component, it will add one to it and return the component.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject);
```
#### Type parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject)-T'></a>
`T`  
A Unity Component  
  
#### Parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject)-gameObject'></a>
`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The GameObject to fetch from or add to  
  
#### Returns
[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject).T')  
The component specified as T  
