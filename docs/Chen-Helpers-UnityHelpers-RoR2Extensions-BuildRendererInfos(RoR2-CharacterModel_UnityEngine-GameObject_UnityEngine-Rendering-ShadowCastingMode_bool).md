
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[RoR2Extensions](./Chen-Helpers-UnityHelpers-RoR2Extensions 'Chen.Helpers.UnityHelpers.RoR2Extensions')

## RoR2Extensions.BuildRendererInfos(RoR2.CharacterModel, UnityEngine.GameObject, UnityEngine.Rendering.ShadowCastingMode, bool) Method
Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.  
```csharp
public static RoR2.CharacterModel.RendererInfo[] BuildRendererInfos(this RoR2.CharacterModel model, UnityEngine.GameObject basisObject, UnityEngine.Rendering.ShadowCastingMode mode, bool ignoreOverlays);
```

#### Parameters
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject_UnityEngine-Rendering-ShadowCastingMode_bool)-model'></a>
`model` [RoR2.CharacterModel](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel 'RoR2.CharacterModel')  
Model to apply the new RendererInfos  
  
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject_UnityEngine-Rendering-ShadowCastingMode_bool)-basisObject'></a>
`basisObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The object basis of where the MeshRenderers will be used to build off with  
  
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject_UnityEngine-Rendering-ShadowCastingMode_bool)-mode'></a>
`mode` [UnityEngine.Rendering.ShadowCastingMode](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Rendering.ShadowCastingMode 'UnityEngine.Rendering.ShadowCastingMode')  
Mode of shadow casting for each mesh  
  
<a name='Chen-Helpers-UnityHelpers-RoR2Extensions-BuildRendererInfos(RoR2-CharacterModel_UnityEngine-GameObject_UnityEngine-Rendering-ShadowCastingMode_bool)-ignoreOverlays'></a>
`ignoreOverlays` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to display effects over the mesh, such as elite prefixes  
  

#### Returns
[RoR2.CharacterModel.RendererInfo](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel.RendererInfo 'RoR2.CharacterModel.RendererInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new set of RendererInfos  
