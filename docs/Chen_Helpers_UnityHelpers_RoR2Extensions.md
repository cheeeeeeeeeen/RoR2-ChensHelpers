#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')
## RoR2Extensions Class
Extensions related to Components defined by Risk of Rain 2.  
```csharp
public static class RoR2Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RoR2Extensions  

| Methods | |
| :--- | :--- |
| [BuildRendererInfos(CharacterModel, GameObject)](Chen_Helpers_UnityHelpers_RoR2Extensions_BuildRendererInfos(RoR2_CharacterModel_UnityEngine_GameObject) 'Chen.Helpers.UnityHelpers.RoR2Extensions.BuildRendererInfos(RoR2.CharacterModel, UnityEngine.GameObject)') | Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.<br/>This overload uses a ShadowCastingMode of Off and IgnoreOverlays of value false.<br/> |
| [BuildRendererInfos(CharacterModel, GameObject, ShadowCastingMode, bool)](Chen_Helpers_UnityHelpers_RoR2Extensions_BuildRendererInfos(RoR2_CharacterModel_UnityEngine_GameObject_UnityEngine_Rendering_ShadowCastingMode_bool) 'Chen.Helpers.UnityHelpers.RoR2Extensions.BuildRendererInfos(RoR2.CharacterModel, UnityEngine.GameObject, UnityEngine.Rendering.ShadowCastingMode, bool)') | Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.<br/> |
| [ReplaceModel(GameObject, GameObject)](Chen_Helpers_UnityHelpers_RoR2Extensions_ReplaceModel(UnityEngine_GameObject_UnityEngine_GameObject) 'Chen.Helpers.UnityHelpers.RoR2Extensions.ReplaceModel(UnityEngine.GameObject, UnityEngine.GameObject)') | Replaces the model inside a GameObject's Model Base.<br/>This is only applicable to GameObjects that have a "ModelBase" or "Model Base" object, as well as a ModelLocator component.<br/>The method will do nothing if it cannot find the model base object.<br/> |
