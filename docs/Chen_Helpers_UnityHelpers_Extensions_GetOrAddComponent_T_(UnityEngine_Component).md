
#### [ChensHelpers](index 'index')

### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](Chen_Helpers_UnityHelpers_Extensions 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(Component) Method
An extension that allows fetching or adding a component through the component of the GameObject.  
If the GameObject has the component, it will only fetch it and return the component.  
If the GameObject does not have the component, it will add one to it and return the component.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.Component component)
    where T : UnityEngine.Component;
```

#### Type parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component)_T'></a>
`T`  
A Unity Component
  

#### Parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component)_component'></a>
`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The GameObject of the component to fetch from or add to
  

#### Returns
[T](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component)#Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component)_T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component).T')  
The component specified as T
