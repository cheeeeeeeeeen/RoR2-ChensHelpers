#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](Chen_Helpers_UnityHelpers_Extensions 'Chen.Helpers.UnityHelpers.Extensions')
## Extensions.DeepCopy&lt;T&gt;(T, GameObject) Method
Creates a deep copy of a component and attaches it to the target Game Object.  
```csharp
public static T DeepCopy<T>(this T originalComponent, GameObject targetGameObject)
    where T : Component;
```
#### Type parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)_T'></a>
`T`  
A Unity Component
  
#### Parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)_originalComponent'></a>
`originalComponent` [T](Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)#Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)_T 'Chen.Helpers.UnityHelpers.Extensions.DeepCopy&lt;T&gt;(T, GameObject).T')  
The basis of the deep copy
  
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)_targetGameObject'></a>
`targetGameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The target Game Object where the deep copy component will be added to
  
#### Returns
[T](Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)#Chen_Helpers_UnityHelpers_Extensions_DeepCopy_T_(T_GameObject)_T 'Chen.Helpers.UnityHelpers.Extensions.DeepCopy&lt;T&gt;(T, GameObject).T')  
The deep copied component
