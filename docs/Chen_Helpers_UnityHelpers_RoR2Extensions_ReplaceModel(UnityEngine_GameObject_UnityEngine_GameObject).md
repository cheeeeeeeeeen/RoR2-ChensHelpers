#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[RoR2Extensions](Chen_Helpers_UnityHelpers_RoR2Extensions 'Chen.Helpers.UnityHelpers.RoR2Extensions')
## RoR2Extensions.ReplaceModel(GameObject, GameObject) Method
Replaces the model inside a GameObject's Model Base.  
This is only applicable to GameObjects that have a "ModelBase" or "Model Base" object, as well as a ModelLocator component.  
The method will do nothing if it cannot find the model base object.  
```csharp
public static void ReplaceModel(this UnityEngine.GameObject originalClonedObject, UnityEngine.GameObject replacementModel);
```
#### Parameters
<a name='Chen_Helpers_UnityHelpers_RoR2Extensions_ReplaceModel(UnityEngine_GameObject_UnityEngine_GameObject)_originalClonedObject'></a>
`originalClonedObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The whole original cloned object
  
<a name='Chen_Helpers_UnityHelpers_RoR2Extensions_ReplaceModel(UnityEngine_GameObject_UnityEngine_GameObject)_replacementModel'></a>
`replacementModel` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The replacement model loaded from an asset bundle
  
