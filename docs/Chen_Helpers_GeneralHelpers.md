#### [ChensHelpers](index 'index')
## Chen.Helpers.GeneralHelpers Namespace

| Classes | |
| :--- | :--- |
| [AssetsManager](Chen_Helpers_GeneralHelpers_AssetsManager 'Chen.Helpers.GeneralHelpers.AssetsManager') | A helper class that handles registering bundles for use in a mod.<br/>Keep an instance of this class internal or local to the mod.<br/> |
| [BlastAttack](Chen_Helpers_GeneralHelpers_BlastAttack 'Chen.Helpers.GeneralHelpers.BlastAttack') | Improvised BlastAttack from Vanilla RoR2 so that it is more helpful for modding.<br/> |
| [DefaultData](Chen_Helpers_GeneralHelpers_DefaultData 'Chen.Helpers.GeneralHelpers.DefaultData') | Static class containing the default set of values for some helpers to work, although an option to provide custom data is supported.<br/>Mainly for doing shortcuts as long as work flow is followed.<br/> |
| [DropletGenerator](Chen_Helpers_GeneralHelpers_DropletGenerator 'Chen.Helpers.GeneralHelpers.DropletGenerator') | A helper that allows listening to function keys to generate pickup droplets in-game.<br/>Press F3 to generate a random white item (or essence).<br/>Press F4 to generate a random green item (or essence).<br/>Press F5 to generate a random red item (or essence).<br/>Press F6 to generate a random orange item (or essence).<br/>Press F7 to generate a random blue (both the item and equipment variants) item (or essence).<br/>Press F8 to generate a random yellow item (or essence).<br/> |
| [Extensions](Chen_Helpers_GeneralHelpers_Extensions 'Chen.Helpers.GeneralHelpers.Extensions') | Extensions related to Components defined by Risk of Rain 2.<br/> |
| [GenericContentPackProvider](Chen_Helpers_GeneralHelpers_GenericContentPackProvider 'Chen.Helpers.GeneralHelpers.GenericContentPackProvider') | An Abstract class for easily implementing Content Pack Providers. It is used for adding new CharacterBody and CharacterMaster GameObjects.<br/>It is recommended to use R2API for adding other objects like Projectiles, etc.<br/> |
| [Instances](Chen_Helpers_GeneralHelpers_Instances 'Chen.Helpers.GeneralHelpers.Instances') | Helper static class that allows the fetching of an instance without the need to write long codes.<br/>Checks are done by this helper and should output a debug log in the console.<br/> |
| [MaterialController](Chen_Helpers_GeneralHelpers_MaterialController 'Chen.Helpers.GeneralHelpers.MaterialController') | A controller for materials so that properties can be inspected and modified.<br/>Attach this component to a Game Object and let it do its magic.<br/>It will attempt to find the correct shader controller from the Renderer's material, attach the said shader controller if found.<br/>After the proper shader controller is found, this component will destroy itself.<br/> |
| [MinionExtensions](Chen_Helpers_GeneralHelpers_MinionExtensions 'Chen.Helpers.GeneralHelpers.MinionExtensions') | Useful extensions related to Minions.<br/> |
| [MultiplayerTest](Chen_Helpers_GeneralHelpers_MultiplayerTest 'Chen.Helpers.GeneralHelpers.MultiplayerTest') | A helper that can enable and disable Multiplayer Testing. Be sure to not enable this in Awake of a mod on release.<br/> |
| [SoundPlayer](Chen_Helpers_GeneralHelpers_SoundPlayer 'Chen.Helpers.GeneralHelpers.SoundPlayer') | A helper class that allows playing sounds easily with just the WWise Event ID and a Keybind.<br/> |

| Structs | |
| :--- | :--- |
| [AssetsManager.BundleInfo](Chen_Helpers_GeneralHelpers_AssetsManager_BundleInfo 'Chen.Helpers.GeneralHelpers.AssetsManager.BundleInfo') | A data structure that holds the information about the bundle.<br/>This is used by the AssetsManager.<br/> |
| [BlastAttack.HitPointAndResult](Chen_Helpers_GeneralHelpers_BlastAttack_HitPointAndResult 'Chen.Helpers.GeneralHelpers.BlastAttack.HitPointAndResult') | Combination of BlastAttack.HitPoint and BlastAttack.Result.<br/> |
| [SoundPlayer.EventPosterKey](Chen_Helpers_GeneralHelpers_SoundPlayer_EventPosterKey 'Chen.Helpers.GeneralHelpers.SoundPlayer.EventPosterKey') | Represents the data structure for a keybind that is responsible for posting WWise sound events.<br/> |

| Enums | |
| :--- | :--- |
| [AssetsManager.BundleType](Chen_Helpers_GeneralHelpers_AssetsManager_BundleType 'Chen.Helpers.GeneralHelpers.AssetsManager.BundleType') | This is used to identify the type of the bundle for differentiation in registration process.<br/> |
