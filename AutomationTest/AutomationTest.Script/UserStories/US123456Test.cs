using App.Entities;
using AutomationTest.Core.Constants;
using AutomationTest.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AutomationTest.Script.UserStories
{
    [TestClass]
    public class US123456Test
    {
        private readonly string userStoryId = "US123456";
        private readonly List<string> fileExceptionMessages = new List<string>
        {
            ExceptionMessages.File.InvalidData,
            ExceptionMessages.File.InvalidName
        };
        private readonly List<string> folderExceptionMessages = new List<string>
        {
            ExceptionMessages.Folder.InvalidNameLength,
            ExceptionMessages.Folder.InvalidName
        };

        [TestMethod]
        public void TestMethod1()
        {
            MyFile file = TestDataStorage.GetFile("Private File", userStoryId);
            MyAttribute attribute = TestDataStorage.GetAttribute("Attribute XXX", userStoryId);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string testCaseId = "TC100";
            List<List<MyAttribute>> attributes = new List<List<MyAttribute>>
            {
                TestDataStorage.GetAttributeList("Attribute List Origin", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 1stUpdate", userStoryId, testCaseId),
                TestDataStorage.GetAttributeList("Attribute List 2ndUpdate", userStoryId, testCaseId)
            };

            for (int i = 0; i< attributes.Count; i++)
            {
                // Action

                // Assert
            }
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
        }
    }
}
