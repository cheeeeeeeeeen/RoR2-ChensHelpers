#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[Extensions](Chen_Helpers_GeneralHelpers_Extensions 'Chen.Helpers.GeneralHelpers.Extensions')
## Extensions.ConvertShaders(AssetBundle, Dictionary&lt;string,string&gt;, string) Method
Replaces all the shaders of the materials in the specified asset bundle.  
The Replacement Dictionary should have keys that should be looked from materials for modification. It should include a prefix to determine which should be modified.  
The respective values for each key will be the replacement.  
```csharp
public static void ConvertShaders(this AssetBundle assetBundle, System.Collections.Generic.Dictionary<string,string> replacementDictionary, string shaderPrefix);
```
#### Parameters
<a name='Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(AssetBundle_System_Collections_Generic_Dictionary_string_string__string)_assetBundle'></a>
`assetBundle` [UnityEngine.AssetBundle](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AssetBundle 'UnityEngine.AssetBundle')  
Asset bundle whose materials will be converted
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(AssetBundle_System_Collections_Generic_Dictionary_string_string__string)_replacementDictionary'></a>
`replacementDictionary` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Dictionary used as reference for replacement
  
<a name='Chen_Helpers_GeneralHelpers_Extensions_ConvertShaders(AssetBundle_System_Collections_Generic_Dictionary_string_string__string)_shaderPrefix'></a>
`shaderPrefix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The prefix of shaders in the bundle the will be replaced
  
