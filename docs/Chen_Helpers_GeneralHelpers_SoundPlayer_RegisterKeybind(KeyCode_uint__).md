#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[SoundPlayer](Chen_Helpers_GeneralHelpers_SoundPlayer 'Chen.Helpers.GeneralHelpers.SoundPlayer')
## SoundPlayer.RegisterKeybind(KeyCode, uint[]) Method
Registers a keybind for a WWise Event that posts the event upon being pressed.  
Duplicated EventPosterKeys will be replaced by a later assignment.  
Alternative overload that does not use the EVentPosterKey data structure.  
```csharp
public void RegisterKeybind(KeyCode key, params uint[] eventIds);
```
#### Parameters
<a name='Chen_Helpers_GeneralHelpers_SoundPlayer_RegisterKeybind(KeyCode_uint__)_key'></a>
`key` [UnityEngine.KeyCode](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.KeyCode 'UnityEngine.KeyCode')  
The key to be assigned
  
<a name='Chen_Helpers_GeneralHelpers_SoundPlayer_RegisterKeybind(KeyCode_uint__)_eventIds'></a>
`eventIds` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Group of Event IDs
  
