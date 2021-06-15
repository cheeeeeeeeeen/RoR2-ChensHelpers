using RoR2.ContentManagement;
using System.Collections;

/// <summary>
/// An Abstract class for easily implementing Content Pack Providers. It is used for adding new CharacterBody and CharacterMaster GameObjects.
/// It is recommended to use R2API for adding other objects like Projectiles, etc.
/// </summary>
public abstract class GenericContentPackProvider : IContentPackProvider
{
    /// <summary>
    /// The Content Pack for this provider. Add here the new contents.
    /// </summary>
    protected ContentPack contentPack = new ContentPack();

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public string identifier => ContentIdentifier();

    public void Initialize() => ContentManager.collectContentPackProviders += addContentPackProvider => addContentPackProvider(this);

    public IEnumerator LoadStaticContentAsync(LoadStaticContentAsyncArgs args)
    {
        contentPack.identifier = identifier;
        LoadStaticContentAsyncActions(args);
        args.ReportProgress(1f);
        yield break;
    }

    public IEnumerator GenerateContentPackAsync(GetContentPackAsyncArgs args)
    {
        ContentPack.Copy(contentPack, args.output);
        args.ReportProgress(1f);
        yield break;
    }

    public IEnumerator FinalizeAsync(FinalizeAsyncArgs args)
    {
        args.ReportProgress(1f);
        yield break;
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// The identifier for this content pack provider. Usually, a Mod GUID is enough for an identifier.
    /// </summary>
    /// <returns>The implemented identifier.</returns>
    protected abstract string ContentIdentifier();

    /// <summary>
    /// The actions where new content can be added.
    /// </summary>
    /// <param name="args">Useful for declaring progress for content additions.</param>
    protected abstract void LoadStaticContentAsyncActions(LoadStaticContentAsyncArgs args);
}