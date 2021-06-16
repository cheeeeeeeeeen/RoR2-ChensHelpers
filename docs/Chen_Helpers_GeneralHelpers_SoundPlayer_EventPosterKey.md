#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers').[SoundPlayer](Chen_Helpers_GeneralHelpers_SoundPlayer 'Chen.Helpers.GeneralHelpers.SoundPlayer')
## SoundPlayer.EventPosterKey Struct
Represents the data structure for a keybind that is responsible for posting WWise sound events.  
```csharp
public struct SoundPlayer.EventPosterKey
```

| Constructors | |
| :--- | :--- |
| [EventPosterKey(KeyCode, uint[])](Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey_EventPosterKey(UnityEngine_KeyCode_uint__) 'Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey.EventPosterKey(UnityEngine.KeyCode, uint[])') | Constructor for building the data for binding keys with assigned Event IDs.<br/>There may be duplicate Event IDs that can exist in one keybind.<br/> |

| Fields | |
| :--- | :--- |
| [eventIds](Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey_eventIds 'Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey.eventIds') | List of Event IDs that will be posted when the assigned key is pressed.<br/> |
| [key](Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey_key 'Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey.key') | The key which will be assigned to post Event IDs.<br/> |
