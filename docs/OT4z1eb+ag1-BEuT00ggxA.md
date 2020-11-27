
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.GeneralHelpers](./ETEQ0RLckShPNesJc2reiw 'Chen.Helpers.GeneralHelpers').[MinionExtensions](./kEQcC4U93L0Ef83VPTXzFg 'Chen.Helpers.GeneralHelpers.MinionExtensions')

## MinionExtensions.AssignOwner(RoR2.CharacterMaster, RoR2.CharacterMaster, bool, bool) Method
Assigns a new owner to the minion. This needs to be called on both the Server and the Client.  
If transmit is true, it only needs to be called on the server.  
The queuing system provides a way to ensure that all clients will sync the owner. This is a slow process though.  
Only set useQueue to true if the client cannot see the objects and returns a warning of the object being null.  
```csharp
public static void AssignOwner(this RoR2.CharacterMaster minion, RoR2.CharacterMaster newOwner, bool transmit=false, bool useQueue=false);
```

#### Parameters
<a name='vG-fwiSa6PaY1ReReNIzAg'></a>
`minion` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
Minion to set a new owner with  
  
<a name='c2VQgpK8by1XjeJlDcHsNQ'></a>
`newOwner` [RoR2.CharacterMaster](https://docs.microsoft.com/en-us/dotnet/api/RoR2.CharacterMaster 'RoR2.CharacterMaster')  
New owner of the minion  
  
<a name='g-zw-crGIop1tSEhMSrMfA'></a>
`transmit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines whether the server would send a sync message to other clients  
  
<a name='6r91d9IUuy3xTmB-9NDT8g'></a>
`useQueue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Tells the client to use a queuing system if transmit is true  
  
