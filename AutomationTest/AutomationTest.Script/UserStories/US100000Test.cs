using App.Entities;
using AutomationTest.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTest.Script.UserStories
{
    [TestClass]
    public class US100000Test
    {
        private readonly string userStoryId = "US100000";

        [TestMethod]
        [DataRow("FolderNoEntities")]
        [DataRow("FolderFullEntities")]
        public void TestMethod1(string dataKey)
        {
            Folder testData = TestDataStorage.GetFolder(dataKey, userStoryId);
        }
    }
}
