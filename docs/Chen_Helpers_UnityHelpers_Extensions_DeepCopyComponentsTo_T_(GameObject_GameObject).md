#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](Chen_Helpers_UnityHelpers_Extensions 'Chen.Helpers.UnityHelpers.Extensions')
## Extensions.DeepCopyComponentsTo&lt;T&gt;(GameObject, GameObject) Method
Creates a deep copy of components from the source towards the specified Game Object.  
```csharp
public static System.Collections.Generic.List<T> DeepCopyComponentsTo<T>(this GameObject sourceGameObject, GameObject targetGameObject)
    where T : Component;
```
#### Type parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopyComponentsTo_T_(GameObject_GameObject)_T'></a>
`T`  
A Unity Component
  
#### Parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopyComponentsTo_T_(GameObject_GameObject)_sourceGameObject'></a>
`sourceGameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
Source where the original components derived from
  
<a name='Chen_Helpers_UnityHelpers_Extensions_DeepCopyComponentsTo_T_(GameObject_GameObject)_targetGameObject'></a>
`targetGameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The target Game Object where components will be copied to
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](Chen_Helpers_UnityHelpers_Extensions_DeepCopyComponentsTo_T_(GameObject_GameObject)#Chen_Helpers_UnityHelpers_Extensions_DeepCopyComponentsTo_T_(GameObject_GameObject)_T 'Chen.Helpers.UnityHelpers.Extensions.DeepCopyComponentsTo&lt;T&gt;(GameObject, GameObject).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of deep copied components
