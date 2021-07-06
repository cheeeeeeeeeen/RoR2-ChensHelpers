#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[Extensions](Chen_Helpers_GeneralHelpers_Extensions 'Chen.Helpers.GeneralHelpers.Extensions')
## Extensions.ConvertShaders(AssetBundle) Method
Replaces all the shaders of the materials in the specified asset bundle.  
Uses the prefix "Fake RoR" as a prefix to match materials whose shaders will be replaced.  
It also uses RoR2Helpers.DefaultData.ShaderReplacements dictionary as reference for replacements.  
```csharp
public static void ConvertShaders(this UnityEngine.AssetBundle assetBundle);
```
#### Parameters
<a name='Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(UnityEngine_AssetBundle)_assetBundle'></a>
`assetBundle` [UnityEngine.AssetBundle](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AssetBundle 'UnityEngine.AssetBundle')  
Asset bundle whose materials will be converted
  
