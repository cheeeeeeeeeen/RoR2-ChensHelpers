
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](./Chen-Helpers-UnityHelpers-Extensions 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component) Method
An extension that allows fetching or adding a component through the component of the GameObject.  
If the GameObject has the component, it will only fetch it and return the component.  
If the GameObject does not have the component, it will add one to it and return the component.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.Component component);
```

#### Type parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component)-T'></a>
`T`  
A Unity Component  
  

#### Parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component)-component'></a>
`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The GameObject of the component to fetch from or add to  
  

#### Returns
[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component).T')  
The component specified as T  
