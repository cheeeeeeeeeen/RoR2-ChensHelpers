
#### [ChensHelpers](index 'index')

### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[MinionExtensions](Chen_Helpers_GeneralHelpers_MinionExtensions 'Chen.Helpers.GeneralHelpers.MinionExtensions')

## MinionExtensions.GetAllMinionComponents&lt;T&gt;(CharacterMaster) Method
Fetches all the minions and fellow minions, then returns a list of the minions' component.  
```csharp
public static System.Collections.Generic.List<T> GetAllMinionComponents<T>(this RoR2.CharacterMaster ownerOrMinion)
    where T : UnityEngine.Component;
```

#### Type parameters
<a name='Chen_Helpers_GeneralHelpers_MinionExtensions_GetAllMinionComponents_T_(RoR2_CharacterMaster)_T'></a>
`T`  
Component to match
  

#### Parameters
<a name='Chen_Helpers_GeneralHelpers_MinionExtensions_GetAllMinionComponents_T_(RoR2_CharacterMaster)_ownerOrMinion'></a>
`ownerOrMinion` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
Master of the minions
  

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](Chen_Helpers_GeneralHelpers_MinionExtensions_GetAllMinionComponents_T_(RoR2_CharacterMaster)#Chen_Helpers_GeneralHelpers_MinionExtensions_GetAllMinionComponents_T_(RoR2_CharacterMaster)_T 'Chen.Helpers.GeneralHelpers.MinionExtensions.GetAllMinionComponents&lt;T&gt;(RoR2.CharacterMaster).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of components of the minions
