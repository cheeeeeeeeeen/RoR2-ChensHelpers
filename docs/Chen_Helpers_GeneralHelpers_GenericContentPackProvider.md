#### [ChensHelpers](index 'index')
### [Chen.Helpers.GeneralHelpers](Chen_Helpers_GeneralHelpers 'Chen.Helpers.GeneralHelpers')
## GenericContentPackProvider Class
An Abstract class for easily implementing Content Pack Providers. It is used for adding new CharacterBody and CharacterMaster GameObjects.  
It is recommended to use R2API for adding other objects like Projectiles, etc.  
```csharp
public abstract class GenericContentPackProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [RoR2.ContentManagement.IContentPackProvider](https://docs.microsoft.com/en-us/dotnet/api/RoR2.ContentManagement.IContentPackProvider 'RoR2.ContentManagement.IContentPackProvider') &#129106; GenericContentPackProvider  

| Fields | |
| :--- | :--- |
| [contentPack](Chen_Helpers_GeneralHelpers_GenericContentPackProvider_contentPack 'Chen.Helpers.GeneralHelpers.GenericContentPackProvider.contentPack') | The Content Pack for this provider. Add here the new contents.<br/> |

| Methods | |
| :--- | :--- |
| [ContentIdentifier()](Chen_Helpers_GeneralHelpers_GenericContentPackProvider_ContentIdentifier() 'Chen.Helpers.GeneralHelpers.GenericContentPackProvider.ContentIdentifier()') | The identifier for this content pack provider. Usually, a Mod GUID is enough for an identifier.<br/> |
| [LoadStaticContentAsyncActions(LoadStaticContentAsyncArgs)](Chen_Helpers_GeneralHelpers_GenericContentPackProvider_LoadStaticContentAsyncActions(LoadStaticContentAsyncArgs) 'Chen.Helpers.GeneralHelpers.GenericContentPackProvider.LoadStaticContentAsyncActions(LoadStaticContentAsyncArgs)') | The actions where new content can be added.<br/> |
