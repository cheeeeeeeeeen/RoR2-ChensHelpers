
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.GeneralHelpers](./Chen-Helpers-GeneralHelpers 'Chen.Helpers.GeneralHelpers').[MinionExtensions](./Chen-Helpers-GeneralHelpers-MinionExtensions 'Chen.Helpers.GeneralHelpers.MinionExtensions')

## MinionExtensions.AssignOwner(RoR2.CharacterMaster, RoR2.CharacterMaster, bool, bool) Method
Assigns a new owner to the minion. This needs to be called on both the Server and the Client.  
If transmit is true, it only needs to be called on the server.  
The queuing system provides a way to ensure that all clients will sync the owner. This is a slow process though.  
Only set useQueue to true if the client cannot see the objects and returns a warning of the object being null.  
```csharp
public static void AssignOwner(this RoR2.CharacterMaster minion, RoR2.CharacterMaster newOwner, bool transmit=false, bool useQueue=false);
```

#### Parameters
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-AssignOwner(RoR2-CharacterMaster_RoR2-CharacterMaster_bool_bool)-minion'></a>
`minion` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
Minion to set a new owner with  
  
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-AssignOwner(RoR2-CharacterMaster_RoR2-CharacterMaster_bool_bool)-newOwner'></a>
`newOwner` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
New owner of the minion  
  
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-AssignOwner(RoR2-CharacterMaster_RoR2-CharacterMaster_bool_bool)-transmit'></a>
`transmit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether the server would send a sync message to other clients  
  
<a name='Chen-Helpers-GeneralHelpers-MinionExtensions-AssignOwner(RoR2-CharacterMaster_RoR2-CharacterMaster_bool_bool)-useQueue'></a>
`useQueue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Tells the client to use a queuing system if transmit is true  
  
