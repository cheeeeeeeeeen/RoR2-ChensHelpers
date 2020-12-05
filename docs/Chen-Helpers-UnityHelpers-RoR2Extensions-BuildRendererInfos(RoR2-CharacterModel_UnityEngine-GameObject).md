
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[RoR2Extensions](./Chen-Helpers-UnityHelpers-RoR2Extensions 'Chen.Helpers.UnityHelpers.RoR2Extensions')

## RoR2Extensions.BuildRendererInfos(RoR2.CharacterModel, UnityEngine.GameObject) Method
Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.  
This overload uses a ShadowCastingMode of Off and IgnoreOverlays of value false.  
```csharp
public static RoR2.CharacterModel.RendererInfo[] BuildRendererInfos(this RoR2.CharacterModel model, UnityEngine.GameObject basisObject);
```

#### Parameters
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject)-model'></a>
`model` [RoR2.CharacterModel](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel 'RoR2.CharacterModel')  
Model to apply the new RendererInfos  
  
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject)-basisObject'></a>
`basisObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The object basis of where the MeshRenderers will be used to build off with  
  

#### Returns
[RoR2.CharacterModel.RendererInfo](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel.RendererInfo 'RoR2.CharacterModel.RendererInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new set of RendererInfos  
