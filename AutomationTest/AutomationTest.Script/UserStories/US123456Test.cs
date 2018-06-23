using App.Entities;
using AutomationTest.Core.Constants;
using AutomationTest.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace AutomationTest.Script.UserStories
{
    [TestClass]
    public class US123456Test
    {
        private readonly string userStoryId = "US123456";
        

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
        [DataRow("Invalid Int32 Attribute")]
        [DataRow("Invalid Int64 Attribute")]
        [DataRow("Invalid JSON Attribute")]
        public void TestMethod3(string dataKey)
        {
            try
            {
                // Action
            }
            catch
            {
                // Assert
            }

            Debug.WriteLine(userStoryId + " - TestMethod3");
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
