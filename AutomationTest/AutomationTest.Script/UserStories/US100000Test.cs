using App.Entities;
using AutomationTest.Core.Helpers;
using LiteDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;

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

        [TestMethod]
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
        public void TestMethod3(string dataKey)
        {
            LiteDatabase db = new LiteDatabase("demo.db");
            Folder testData = TestDataStorage.GetFolder(dataKey, userStoryId);
            db.GetCollection<Folder>("Data").Insert(testData);
            db.FileStorage.Upload(testData.Id.ToString(), "demo", new MemoryStream(testData.Files[1].Data));

            int count = db.GetCollection<Folder>("Data").Count();
            Debug.WriteLine(userStoryId + " - TestMethod3 - " + count);
        }
    }
}
