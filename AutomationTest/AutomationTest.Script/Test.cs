using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;
using AutomationTest.Core.Helpers;

namespace AutomationTest.Script
{
    [TestClass]
    public class Test
    {
        private readonly string userStoryId = "US100000";

        [TestMethod]
        [DataRow("FolderNoEntities")]
        [DataRow("FolderFullEntities")]
        public void TestMethod1(string dataKey)
        {
            Folder testData = TestDataStorage.GetFolder(dataKey, "US100000");
        }
    }
}
