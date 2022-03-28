#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers')
## SoundPlayer Class
A helper class that allows playing sounds easily with just the WWise Event ID and a Keybind.  
```csharp
public class SoundPlayer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SoundPlayer  

| Constructors | |
| :--- | :--- |
| [SoundPlayer(EventPosterKey[])](Chen_Helpers_GeneralHelpers_SoundPlayer_SoundPlayer(Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey__) 'Chen.Helpers.GeneralHelpers.SoundPlayer.SoundPlayer(Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey[])') | Constructor to create an instance of the class.<br/>A group of EventPosterKeys may be passed as parameters to automatically register them.<br/> |

| Methods | |
| :--- | :--- |
| [RegisterKeybind(EventPosterKey)](Chen_Helpers_GeneralHelpers_SoundPlayer_RegisterKeybind(Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey) 'Chen.Helpers.GeneralHelpers.SoundPlayer.RegisterKeybind(Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey)') | Registers a keybind for a WWise Event that posts the event upon being pressed.<br/>Duplicated EventPosterKeys will be replaced by a later assignment.<br/> |
| [RegisterKeybind(KeyCode, uint[])](Chen_Helpers_GeneralHelpers_SoundPlayer_RegisterKeybind(KeyCode_uint__) 'Chen.Helpers.GeneralHelpers.SoundPlayer.RegisterKeybind(KeyCode, uint[])') | Registers a keybind for a WWise Event that posts the event upon being pressed.<br/>Duplicated EventPosterKeys will be replaced by a later assignment.<br/>Alternative overload that does not use the EVentPosterKey data structure.<br/> |
| [Update()](Chen_Helpers_GeneralHelpers_SoundPlayer_Update() 'Chen.Helpers.GeneralHelpers.SoundPlayer.Update()') | Place this in a BaseUnityPlugin.Update() to enable the listeners for the keybinds registered.<br/> |
