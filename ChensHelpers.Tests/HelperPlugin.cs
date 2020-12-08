using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassBeingTested = Chen.Helpers.HelperPlugin;

namespace Chen.Helpers.Tests
{
    [TestClass]
    public class HelperPlugin
    {
        [TestMethod]
        public void ModVer_Length_ReturnsCorrectFormat()
        {
            string result = ClassBeingTested.ModVer;
            const int ModVersionCount = 3;

            int count = result.Split('.').Length;

            Assert.AreEqual(ModVersionCount, count);
        }

        [TestMethod]
        public void ModName_Value_ReturnsCorrectName()
        {
            string result = ClassBeingTested.ModName;
            const string ModName = "ChensHelpers";

            Assert.AreEqual(ModName, result);
        }

        [TestMethod]
        public void ModGuid_Value_ReturnsCorrectGuid()
        {
            string result = ClassBeingTested.ModGuid;
            const string ModGuid = "com.Chen.ChensHelpers";

            Assert.AreEqual(ModGuid, result);
        }
    }
}