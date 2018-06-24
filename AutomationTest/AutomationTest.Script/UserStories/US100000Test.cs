using App.Entities;
using AutomationTest.Core.Helpers;
using LiteDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        public void GetFolderTest(string dataKey)
        {
            Service service = new Service();

            using (LiteDatabaseHelper db = new LiteDatabaseHelper())
            {
                // Prepare Test Data
                Folder folder = TestDataStorage.GetFolder(dataKey, userStoryId);

                // Given: I has existed folder (*) with known id in database
                Guid id = db.Folder.Insert(folder).AsGuid;

                // When: I use method GetFolder by id
                Folder result = service.GetFolder(id);

                // Then: It return exact folder's data that i want to get from database
                Assert.IsTrue(CompareHelper.AreEqualFolders(folder, result));
            }

            Debug.WriteLine(userStoryId + " - GetFolderTest");
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
            using (LiteDatabaseHelper db = new LiteDatabaseHelper())
            {
                Folder testData = TestDataStorage.GetFolder(dataKey, userStoryId);
                db.Folder.Insert(testData);
                db.FileStorage.Upload(testData.Id.ToString(), "demo", new MemoryStream(testData.Files[1].Data));

                int count = db.Folder.Count();
                Debug.WriteLine(userStoryId + " - TestMethod3 - " + count);
            }
        }
    }
}
