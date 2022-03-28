#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers')
## Extensions Class
Extensions related to Components defined by Risk of Rain 2.  
```csharp
public static class Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Extensions  

| Methods | |
| :--- | :--- |
| [BuildRendererInfos(CharacterModel, GameObject)](Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject) 'Chen.Helpers.GeneralHelpers.Extensions.BuildRendererInfos(CharacterModel, GameObject)') | Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.<br/>This overload uses a ShadowCastingMode of Off and IgnoreOverlays of value false.<br/> |
| [BuildRendererInfos(CharacterModel, GameObject, ShadowCastingMode, bool)](Chen_Helpers_GeneralHelpers_Extensions_BuildRendererInfos(CharacterModel_GameObject_ShadowCastingMode_bool) 'Chen.Helpers.GeneralHelpers.Extensions.BuildRendererInfos(CharacterModel, GameObject, ShadowCastingMode, bool)') | Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.<br/> |
| [ConvertShaders(AssetBundle)](Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(AssetBundle) 'Chen.Helpers.GeneralHelpers.Extensions.ConvertShaders(AssetBundle)') | Replaces all the shaders of the materials in the specified asset bundle.<br/>Uses the prefix "Fake RoR" as a prefix to match materials whose shaders will be replaced.<br/>It also uses RoR2Helpers.DefaultData.ShaderReplacements dictionary as reference for replacements.<br/> |
| [ConvertShaders(AssetBundle, Dictionary&lt;string,string&gt;, string)](Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(AssetBundle_System_Collections_Generic_Dictionary_string_string__string) 'Chen.Helpers.GeneralHelpers.Extensions.ConvertShaders(AssetBundle, System.Collections.Generic.Dictionary&lt;string,string&gt;, string)') | Replaces all the shaders of the materials in the specified asset bundle.<br/>The Replacement Dictionary should have keys that should be looked from materials for modification. It should include a prefix to determine which should be modified.<br/>The respective values for each key will be the replacement.<br/> |
| [ReplaceModel(GameObject, GameObject, bool)](Chen_Helpers_GeneralHelpers_Extensions_ReplaceModel(GameObject_GameObject_bool) 'Chen.Helpers.GeneralHelpers.Extensions.ReplaceModel(GameObject, GameObject, bool)') | Replaces the model inside a GameObject's Model Base.<br/>This is only applicable to GameObjects that have a "ModelBase" or "Model Base" object, as well as a ModelLocator component.<br/>The method will do nothing if it cannot find the model base object.<br/> |
