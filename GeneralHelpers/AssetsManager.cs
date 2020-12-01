using Chen.Helpers.CollectionHelpers;
using R2API;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// A helper class that handles registering bundles for use in a mod.
    /// Keep an instance of this class internal or local to the mod.
    /// </summary>
    public class AssetsManager
    {
        private readonly List<BundleInfo> bundleInfos = new List<BundleInfo>();

        /// <summary>
        /// The default constructor one may use to add bundles later.
        /// </summary>
        public AssetsManager()
        {
        }

        /// <summary>
        /// Constructor to use if the bundles are already made.
        /// </summary>
        /// <param name="bundles">Group of bundles for the helper class to manage</param>
        public AssetsManager(params BundleInfo[] bundles)
        {
            bundleInfos.ConditionalAddRange(bundles, (listItem, arrayItem) => listItem.Equals(arrayItem));
        }

        /// <summary>
        /// Used to add a bundle for the manager to handle.
        /// </summary>
        /// <param name="bundle">A bundle data</param>
        /// <returns>True if the bundle is added. False if the bundle already exists or has the same name.</returns>
        public bool Add(BundleInfo bundle) => bundleInfos.ConditionalAdd(bundle, (listItem) => listItem.Equals(bundle));

        /// <summary>
        /// Used to add a bundle for the manager to handle.
        /// This is an overload alternative.
        /// </summary>
        /// <param name="modPrefix">Prefix to use for the bundle</param>
        /// <param name="source">Embedded resource path of the bundle</param>
        /// <param name="type">Bundle Type</param>
        /// <returns>True if the bundle is added. False if the bundle already exists or has the same name.</returns>
        public bool Add(string modPrefix, string source, BundleType type)
        {
            return Add(new BundleInfo(modPrefix, source, type));
        }

        /// <summary>
        /// Invoke this method to start registering all bundles assigned to this manager.
        /// </summary>
        public void RegisterAll()
        {
            foreach (BundleInfo bundleInfo in bundleInfos)
            {
                using (var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(bundleInfo.source))
                {
                    switch (bundleInfo.type)
                    {
                        case BundleType.UnityAssetBundle:
                            var bundle = AssetBundle.LoadFromStream(stream);
                            var provider = new AssetBundleResourcesProvider(bundleInfo.modPrefix, bundle);
                            ResourcesAPI.AddProvider(provider);
                            break;

                        case BundleType.WWiseSoundBank:
                            var bytes = new byte[stream.Length];
                            stream.Read(bytes, 0, bytes.Length);
                            SoundAPI.SoundBanks.Add(bytes);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// A data structure that holds the information about the bundle.
        /// This is used by the AssetsManager.
        /// </summary>
        public struct BundleInfo : IEquatable<BundleInfo>
        {
            /// <summary>
            /// The mod prefix is defined to be the identifier to the bundle for accessing. It should always start with "@".
            /// </summary>
            public string modPrefix;
            /// <summary>
            /// The source is the resource path as defined by a mod. The bundle must be Embedded as Resource.
            /// </summary>
            public string source;
            /// <summary>
            /// Type of the bundle.
            /// </summary>
            public BundleType type;

            /// <summary>
            /// Constructor used to build BundleInfo.
            /// </summary>
            /// <param name="modPrefix">The prefix used to access the bundle</param>
            /// <param name="source">The resource path of the bundle</param>
            /// <param name="type">Type of the bundle</param>
            public BundleInfo(string modPrefix, string source, BundleType type)
            {
                this.modPrefix = modPrefix;
                this.source = source;
                this.type = type;
            }

            /// <summary>
            /// Defines the equality of this struct. Always use this method to compare BundleInfo data.
            /// </summary>
            /// <param name="other">The other BundleInfo to compare with</param>
            /// <returns>The equality truthiness</returns>
            public bool Equals(BundleInfo other) => modPrefix == other.modPrefix && source == other.source;
        }

        /// <summary>
        /// This is used to identify the type of the bundle for differentiation in registration process.
        /// </summary>
        public enum BundleType : byte
        {
            /// <summary>
            /// This Bundle Type refers to the asset bundles generated in Unity through AssetBundleBrowser.
            /// </summary>
            UnityAssetBundle,
            /// <summary>
            /// This Bundle Type refers to the sound bank generated by WWise.
            /// </summary>
            WWiseSoundBank
        }
    }
}