#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers')
## MinionExtensions Class
Useful extensions related to Minions.  
```csharp
public static class MinionExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MinionExtensions  

| Methods | |
| :--- | :--- |
| [AssignOwner(CharacterMaster, CharacterMaster, bool, bool)](Chen_Helpers_GeneralHelpers_MinionExtensions_AssignOwner(CharacterMaster_CharacterMaster_bool_bool) 'Chen.Helpers.GeneralHelpers.MinionExtensions.AssignOwner(CharacterMaster, CharacterMaster, bool, bool)') | Assigns a new owner to the minion. This needs to be called on both the Server and the Client.<br/>If transmit is true, it only needs to be called on the server.<br/>The queuing system provides a way to ensure that all clients will sync the owner. This is a slow process though.<br/>Only set useQueue to true if the client cannot see the objects and returns a warning of the object being null.<br/> |
| [GetAllMinionComponents&lt;T&gt;(CharacterMaster)](Chen_Helpers_GeneralHelpers_MinionExtensions_GetAllMinionComponents_T_(CharacterMaster) 'Chen.Helpers.GeneralHelpers.MinionExtensions.GetAllMinionComponents&lt;T&gt;(CharacterMaster)') | Fetches all the minions and fellow minions, then returns a list of the minions' component.<br/> |
| [LoopMinions(CharacterMaster, Action&lt;CharacterMaster&gt;)](Chen_Helpers_GeneralHelpers_MinionExtensions_LoopMinions(CharacterMaster_System_Action_CharacterMaster_) 'Chen.Helpers.GeneralHelpers.MinionExtensions.LoopMinions(CharacterMaster, System.Action&lt;CharacterMaster&gt;)') | Loops through the minions and fellow minions, then applies processing for each through an action.<br/> |
