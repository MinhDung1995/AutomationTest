using App.Entities;
using AutomationTest.Core.Constants;
using AutomationTest.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AutomationTest.Script.UserStories
{
    [TestClass]
    public class US123456Test
    {
        private readonly string userStoryId = "US123456";

        [TestMethod]
        public void SaveFolderTest_Success1()
        {
            string testCaseId = "TC100";
            Service service = new Service();

            using (LiteDatabaseHelper db = new LiteDatabaseHelper())
            {
                // Prepare Test Data
                Folder result;
                Folder folder = TestDataStorage.GetFolder("Folder Origin", userStoryId, testCaseId);
                List<List<MyAttribute>> attributeList = new List<List<MyAttribute>>
                {
                    TestDataStorage.GetAttributeList("Attribute List Origin", userStoryId, testCaseId),
                    TestDataStorage.GetAttributeList("Attribute List 1stUpdate", userStoryId, testCaseId),
                    TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId)
                };

                // Given: I has existed folder (*) with known id in database
                Guid id = db.Folder.Insert(folder).AsGuid;

                for (int i = 0; i < attributeList.Count; i++)
                {
                    // And: I have changed its attributes
                    folder.Attributes = attributeList[i];

                    // When: I save it by using method SaveFolder
                    result = service.SaveFolder(folder, folder.Id);

                    // Then: It return exact folder's data that i have saved with new id
                    folder.Id = result.Id;
                    Assert.IsTrue(CompareHelper.AreEqualFolders(folder, result));
                }
            }
            
            Debug.WriteLine(userStoryId + " - SaveFolderTest_Success1");
        }

        [TestMethod]
        [DataRow("Attribute List Origin")]
        [DataRow("Attribute List 1stUpdate")]
        [DataRow("Attribute List 2ndUpdate")]
        public void SaveFolderTest_Success2(string dataKey)
        {
            string testCaseId = "TC100";
            Service service = new Service();

            using (LiteDatabaseHelper db = new LiteDatabaseHelper())
            {
                // Prepare Test Data
                Folder result;
                Folder folder = TestDataStorage.GetFolder("Folder Origin", userStoryId, testCaseId);
                List<MyAttribute> attributeList = TestDataStorage.GetAttributeList(dataKey, userStoryId, testCaseId);

                // Given: I has existed folder (*) with known id in database
                Guid id = db.Folder.Insert(folder).AsGuid;

                // And: I have changed its attributes
                folder.Attributes = attributeList;

                // When: I save it by using method SaveFolder
                result = service.SaveFolder(folder, folder.Id);

                // Then: It return exact folder's data that i have saved with new id
                folder.Id = result.Id;
                Assert.IsTrue(CompareHelper.AreEqualFolders(folder, result));
            }

            Debug.WriteLine(userStoryId + " - SaveFolderTest_Success2");
        }

        [TestMethod]
        [DataRow("Attribute Invalid Name", "Invalid Name")]
        [DataRow("Attribute Invalid Length Name", "Invalid Length Name")]
        public void SaveFolderTest_Fail(string dataKey, string exceptionMsgKey)
        {
            try
            {
                string testCaseId = "TC200";
                Service service = new Service();

                using (LiteDatabaseHelper db = new LiteDatabaseHelper())
                {
                    // Prepare Test Data
                    Folder result;
                    Folder folder = TestDataStorage.GetFolder("Folder Origin", userStoryId, testCaseId);
                    MyAttribute invalidAttribute = TestDataStorage.GetAttribute(dataKey, userStoryId, testCaseId);

                    // Given: I has existed folder (*) with known id in database
                    Guid id = db.Folder.Insert(folder).AsGuid;

                    // And: I have added invalid attribute
                    folder.Attributes.Add(invalidAttribute);

                    // When: I save it by using method SaveFolder
                    result = service.SaveFolder(folder, folder.Id);

                    Assert.Fail();
                }
            }
            catch (Exception ex)
            {
                // Then: It throw exception based on invalid type
                Assert.AreEqual(ex.Message, ExceptionMessages.AttributeExceptionMessages[exceptionMsgKey]);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string testCaseId = "TC100";
            List<List<MyAttribute>> attributes = new List<List<MyAttribute>>
            {
                TestDataStorage.GetAttributeList("Attribute List Origin", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 1stUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),

                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),

                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),

                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),

                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),

                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId),
            };

            for (int i = 0; i< attributes.Count; i++)
            {
                // Action

                // Assert
            }

            Debug.WriteLine(userStoryId + " - TestMethod2");
        }

        [TestMethod]
        public void TestMethod4()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod4");
        }

        [TestMethod]
        public void TestMethod5()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod5");
        }

        [TestMethod]
        public void TestMethod6()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod6");
        }

        [TestMethod]
        public void TestMethod7()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod7");
        }

        [TestMethod]
        public void TestMethod8()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file1 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute1 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file2 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute2 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod8");
        }

        [TestMethod]
        public void TestMethod9()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file1 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute1 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file2 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute2 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod9");
        }

        [TestMethod]
        public void TestMethod10()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file1 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute1 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
            MyFile file2 = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute2 = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);

            Debug.WriteLine(userStoryId + " - TestMethod10");
        }
    }
}
