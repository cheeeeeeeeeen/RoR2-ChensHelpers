#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[Extensions](Chen_Helpers_GeneralHelpers_Extensions 'Chen.Helpers.GeneralHelpers.Extensions')
## Extensions.BuildRendererInfos(CharacterModel, GameObject) Method
Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.  
This overload uses a ShadowCastingMode of Off and IgnoreOverlays of value false.  
```csharp
public static RendererInfo[] BuildRendererInfos(this CharacterModel model, GameObject basisObject);
```
#### Parameters
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject)_model'></a>
`model` [RoR2.CharacterModel](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterModel 'RoR2.CharacterModel')  
Model to apply the new RendererInfos
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject)_basisObject'></a>
`basisObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The object basis of where the MeshRenderers will be used to build off with
  
#### Returns
[RoR2.RendererInfo](https://docs.microsoft.com/en-us/dotnet/api/RoR2.RendererInfo 'RoR2.RendererInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A new set of RendererInfos
