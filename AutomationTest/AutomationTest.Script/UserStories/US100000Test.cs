using App.Entities;
using AutomationTest.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

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

            Debug.WriteLine(userStoryId + " - TestMethod1");
        }

        [TestMethod]
        [DataRow("FolderNoEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        [DataRow("FolderFullEntities")]
        public void TestMethod2(string dataKey)
        {
            Folder testData = TestDataStorage.GetFolder(dataKey, userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod2");
        }
    }
}
