
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[RoR2Extensions](./Chen-Helpers-UnityHelpers-RoR2Extensions 'Chen.Helpers.UnityHelpers.RoR2Extensions')

## RoR2Extensions.ReplaceModel(UnityEngine.GameObject, UnityEngine.GameObject) Method
Replaces the model inside a GameObject's Model Base.  
This is only applicable to GameObjects that have a "ModelBase" or "Model Base" object, as well as a ModelLocator component.  
The method will do nothing if it cannot find the model base object.  
```csharp
public static void ReplaceModel(this UnityEngine.GameObject originalClonedObject, UnityEngine.GameObject replacementModel);
```

#### Parameters
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-ReplaceModel(UnityEngine-GameObject_UnityEngine-GameObject)-originalClonedObject'></a>
`originalClonedObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The whole original cloned object  
  
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-ReplaceModel(UnityEngine-GameObject_UnityEngine-GameObject)-replacementModel'></a>
`replacementModel` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The replacement model loaded from an asset bundle  
  
