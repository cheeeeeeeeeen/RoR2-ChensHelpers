#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[Extensions](Chen_Helpers_GeneralHelpers_Extensions 'Chen.Helpers.GeneralHelpers.Extensions')
## Extensions.BuildRendererInfos(CharacterModel, GameObject, ShadowCastingMode, bool) Method
Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.  
```csharp
public static RendererInfo[] BuildRendererInfos(this CharacterModel model, GameObject basisObject, ShadowCastingMode mode, bool ignoreOverlays);
```
#### Parameters
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject_ShadowCastingMode_bool)_model'></a>
`model` [RoR2.CharacterModel](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel 'RoR2.CharacterModel')  
Model to apply the new RendererInfos
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject_ShadowCastingMode_bool)_basisObject'></a>
`basisObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The object basis of where the MeshRenderers will be used to build off with
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject_ShadowCastingMode_bool)_mode'></a>
`mode` [UnityEngine.Rendering.ShadowCastingMode](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Rendering.ShadowCastingMode 'UnityEngine.Rendering.ShadowCastingMode')  
Mode of shadow casting for each mesh
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject_ShadowCastingMode_bool)_ignoreOverlays'></a>
`ignoreOverlays` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether to display effects over the mesh, such as elite prefixes
  
#### Returns
[RoR2.RendererInfo](https://docs.microsoft.com/en-us/dotnet/api/RoR2.RendererInfo 'RoR2.RendererInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new set of RendererInfos
