
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.GeneralHelpers](./Chen-Helpers-GeneralHelpers 'Chen.Helpers.GeneralHelpers').[MinionExtensions](./Chen-Helpers-GeneralHelpers-MinionExtensions 'Chen.Helpers.GeneralHelpers.MinionExtensions')

## MinionExtensions.LoopMinions(RoR2.CharacterMaster, System.Action&lt;RoR2.CharacterMaster&gt;) Method
Loops through the minions and fellow minions, then applies processing for each through an action.  
```csharp
public static void LoopMinions(this RoR2.CharacterMaster ownerOrMinion, System.Action<RoR2.CharacterMaster> logic);
```

#### Parameters
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-LoopMinions(RoR2-CharacterMaster_System-Action-RoR2-CharacterMaster-)-ownerOrMinion'></a>
`ownerOrMinion` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
Master of the minions or a fellow minion  
  
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-LoopMinions(RoR2-CharacterMaster_System-Action-RoR2-CharacterMaster-)-logic'></a>
`logic` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Code to apply for each minion  
  
