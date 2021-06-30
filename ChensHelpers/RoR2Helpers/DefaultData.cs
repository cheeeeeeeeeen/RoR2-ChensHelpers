using System.Collections.Generic;

namespace Chen.Helpers.RoR2Helpers
{
    /// <summary>
    /// Static class containing the default set of values for some helpers to work, although an option to provide custom data is supported.
    /// Mainly for doing shortcuts as long as work flow is followed.
    /// </summary>
    public static class DefaultData
    {
        /// <summary>
        /// Default Shader Replacements data. "Fake RoR" is used a prefix for this dictionary.
        /// </summary>
        public static Dictionary<string, string> ShaderReplacements = new Dictionary<string, string>()
        {
            { "fake ror/hopoo games/deferred/hgstandard", "shaders/deferred/hgstandard" },
            { "fake ror/hopoo games/fx/hgcloud intersection remap", "shaders/fx/hgintersectioncloudremap" },
            { "fake ror/hopoo games/fx/hgcloud remap", "shaders/fx/hgcloudremap" },
            { "fake ror/hopoo games/fx/hgdistortion", "shaders/fx/hgdistortion" },
            { "fake ror/hopoo games/deferred/hgsnow topped", "shaders/deferred/snow topped" }
        };
    }
}