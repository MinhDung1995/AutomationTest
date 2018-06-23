using App.Entities;
using AutomationTest.Core.Core;
using System;
using System.Collections.Generic;

namespace AutomationTest.Core.Helpers
{
    public static class TestDataStorage
    {
        public static Folder GetFolder(string dataKey, string userStoryId, string testCaseId = null)
        {
            JsonTestDataReader reader = new JsonTestDataReader(userStoryId, testCaseId, dataKey);

            Folder folder = reader.GetTestData<Folder>();
            folder.Id = Guid.NewGuid();
            folder.CreatedDateTime = DateTime.Now;

            return folder;
        }

        public static MyFile GetFile(string dataKey, string userStoryId, string testCaseId = null)
        {
            JsonTestDataReader reader = new JsonTestDataReader(userStoryId, testCaseId, dataKey);

            MyFile file = reader.GetTestData<MyFile>();

            return file;
        }

        public static List<MyAttribute> GetAttributeList(string v1, string userStoryId, string v2)
        {
            throw new NotImplementedException();
        }

        public static MyAttribute GetAttribute(string dataKey, string userStoryId, string testCaseId = null)
        {
            JsonTestDataReader reader = new JsonTestDataReader(userStoryId, testCaseId, dataKey);

            MyAttribute attribute = reader.GetTestData<MyAttribute>();

            return attribute;
        }
    }
}
