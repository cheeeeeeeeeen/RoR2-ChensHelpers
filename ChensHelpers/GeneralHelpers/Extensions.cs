using RoR2;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using static Chen.Helpers.GeneralHelpers.DefaultData;
using static RoR2.CharacterModel;
using UnityObject = UnityEngine.Object;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// Extensions related to Components defined by Risk of Rain 2.
    /// </summary>
    public static class Extensions
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
        /// <param name="debug">Set to true to attach the Material Controller for modifying materials in-game.</param>
        public static void ReplaceModel(this GameObject originalClonedObject, GameObject replacementModel, bool debug = false)
        {
            ModelLocator modelLocator = originalClonedObject.GetComponent<ModelLocator>();
            if (modelLocator)
            {
                Transform node;
                if (node = originalClonedObject.transform.Find("ModelBase")) UnityObject.Destroy(node.gameObject);
                if (node = originalClonedObject.transform.Find("Model Base")) UnityObject.Destroy(node.gameObject);
            }
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
            if (debug) replacementModel.AddComponent<MaterialController>();
        }

        /// <summary>
        /// Replaces all the shaders of the materials in the specified asset bundle.
        /// The Replacement Dictionary should have keys that should be looked from materials for modification. It should include a prefix to determine which should be modified.
        /// The respective values for each key will be the replacement.
        /// </summary>
        /// <param name="assetBundle">Asset bundle whose materials will be converted</param>
        /// <param name="replacementDictionary">Dictionary used as reference for replacement</param>
        /// <param name="shaderPrefix">The prefix of shaders in the bundle the will be replaced</param>
        public static void ConvertShaders(this AssetBundle assetBundle, Dictionary<string, string> replacementDictionary, string shaderPrefix)
        {
            bool materialFilter(Material material) => material.shader.name.ToLower().StartsWith(shaderPrefix.ToLower());
            IEnumerable<Material> materialAssets = assetBundle.LoadAllAssets<Material>().Where(materialFilter);
            foreach (Material material in materialAssets)
            {
                Shader replacementShader = Resources.Load<Shader>(replacementDictionary[material.shader.name.ToLower()]);
                if (replacementShader) material.shader = replacementShader;
            }
        }

        /// <summary>
        /// Replaces all the shaders of the materials in the specified asset bundle.
        /// Uses the prefix "Fake RoR" as a prefix to match materials whose shaders will be replaced.
        /// It also uses RoR2Helpers.DefaultData.ShaderReplacements dictionary as reference for replacements.
        /// </summary>
        /// <param name="assetBundle">Asset bundle whose materials will be converted</param>
        public static void ConvertShaders(this AssetBundle assetBundle) => assetBundle.ConvertShaders(ShaderReplacements, "Fake RoR");
    }
}