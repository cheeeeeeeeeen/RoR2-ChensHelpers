using RoR2;
using UnityEngine;
using UnityEngine.Rendering;
using static RoR2.CharacterModel;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// Extensions related to Components defined by Risk of Rain 2.
    /// </summary>
    public static class RoR2Extensions
    {
        /// <summary>
        /// Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.
        /// This overload uses a ShadowCastingMode of Off and IgnoreOverlays of value false.
        /// </summary>
        /// <param name="model">Model to apply the new RendererInfos</param>
        /// <param name="basisObject">The object basis of where the MeshRenderers will be used to build off with</param>
        /// <returns>A new set of RendererInfos</returns>
        public static RendererInfo[] BuildRendererInfos(this CharacterModel model, GameObject basisObject)
        {
            return model.BuildRendererInfos(basisObject, ShadowCastingMode.Off, false);
        }

        /// <summary>
        /// Builds the renderer information data structure from scratch based on the given GameObject's MeshRenderer components.
        /// </summary>
        /// <param name="model">Model to apply the new RendererInfos</param>
        /// <param name="basisObject">The object basis of where the MeshRenderers will be used to build off with</param>
        /// <param name="mode">Mode of shadow casting for each mesh</param>
        /// <param name="ignoreOverlays">Determines whether to display effects over the mesh, such as elite prefixes</param>
        /// <returns>A new set of RendererInfos</returns>
        public static RendererInfo[] BuildRendererInfos(this CharacterModel model, GameObject basisObject, ShadowCastingMode mode, bool ignoreOverlays)
        {
            MeshRenderer[] meshes = basisObject.GetComponentsInChildren<MeshRenderer>();
            model.baseRendererInfos = new RendererInfo[meshes.Length];

            for (int i = 0; i < meshes.Length; i++)
            {
                model.baseRendererInfos[i] = new RendererInfo
                {
                    defaultMaterial = meshes[i].material,
                    renderer = meshes[i],
                    defaultShadowCastingMode = mode,
                    ignoreOverlays = ignoreOverlays
                };
            }

            return model.baseRendererInfos;
        }
    }
}
