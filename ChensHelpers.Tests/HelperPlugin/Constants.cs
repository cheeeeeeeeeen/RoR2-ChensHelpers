using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chen.Helpers.Tests.HelperPlugin
{
    [TestClass]
    public class Constants
    {
        [TestMethod]
        public void ModVer_Length_ReturnsCorrectFormat()
        {
            string result = Helpers.HelperPlugin.ModVer;
            const int ModVersionCount = 3;

            int count = result.Split('.').Length;

            Assert.AreEqual(ModVersionCount, count);
        }

        [TestMethod]
        public void ModName_Value_ReturnsCorrectName()
        {
            string result = Helpers.HelperPlugin.ModName;
            const string ModName = "ChensHelpers";

            Assert.AreEqual(ModName, result);
        }

        [TestMethod]
        public void ModGuid_Value_ReturnsCorrectGuid()
        {
            string result = Helpers.HelperPlugin.ModGuid;
            const string ModGuid = "com.Chen.ChensHelpers";

            Assert.AreEqual(ModGuid, result);
        }
    }
}