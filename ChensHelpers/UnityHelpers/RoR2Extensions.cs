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
            return model.BuildRendererInfos(basisObject, ShadowCastingMode.On, false);
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

        /// <summary>
        /// Replaces the model inside a GameObject's Model Base.
        /// This is only applicable to GameObjects that have a "ModelBase" or "Model Base" object, as well as a ModelLocator component.
        /// The method will do nothing if it cannot find the model base object.
        /// </summary>
        /// <param name="originalClonedObject">The whole original cloned object</param>
        /// <param name="replacementModel">The replacement model loaded from an asset bundle</param>
        public static void ReplaceModel(this GameObject originalClonedObject, GameObject replacementModel)
        {
            Transform node;
            ModelLocator modelLocator = originalClonedObject.GetComponent<ModelLocator>();
            if (modelLocator && ((node = originalClonedObject.transform.Find("ModelBase")) || (node = originalClonedObject.transform.Find("Model Base")))) Object.Destroy(node);
            else return;

            GameObject modelBase = new GameObject("ModelBase");
            modelBase.transform.parent = originalClonedObject.transform;
            modelBase.transform.localPosition = Vector3.zero;
            modelBase.transform.localRotation = Quaternion.identity;
            modelBase.transform.localScale = Vector3.one;
            Transform modelTransform = replacementModel.transform;
            modelTransform.parent = modelBase.transform;
            modelTransform.localPosition = Vector3.zero;
            modelTransform.localRotation = Quaternion.identity;
            modelLocator.modelTransform = replacementModel.transform;
            modelLocator.modelBaseTransform = modelBase.transform;
        }
    }
}