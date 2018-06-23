using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomationTest.Core.Core
{
    public class JsonTestDataReader
    {
        private readonly string _userStoryId = string.Empty;
        private readonly string _testCaseId = string.Empty;
        private readonly string _dataKey = string.Empty;

        public JsonTestDataReader(string userStoryId, string testCaseId, string dataKey)
        {
            if (string.IsNullOrWhiteSpace(userStoryId))
            {
                throw new ArgumentNullException("User Story Id must not be null, empty or consists only of white-space characters");
            }

            if (string.IsNullOrWhiteSpace(testCaseId))
            {
                throw new ArgumentNullException("Test Case Id must not be null, empty or consists only of white-space characters");
            }

            if (string.IsNullOrWhiteSpace(dataKey))
            {
                throw new ArgumentNullException("Data Id must not be null, empty or consists only of white-space characters");
            }

            _userStoryId = userStoryId;
            _testCaseId = testCaseId;
            _dataKey = dataKey;
        }

        public JsonTestDataReader(string userStoryId, string dataKey) : this(userStoryId, "shared", dataKey)
        {

        }

        private string LoadJson()
        {
            string path = string.Format(@"TestData\{0}\{1}.json", _userStoryId, _testCaseId);

            using (StreamReader stream = new StreamReader(path))
            {
                string json = stream.ReadToEnd();
                JArray jsonObjects = JArray.Parse(json);

                if (jsonObjects == null)
                {
                    throw new Exception("Wrong format test data in json");
                }

                IEnumerable<JToken> jTokens = jsonObjects.Where(o => o["Key"].ToString().Equals(_dataKey))
                    .ToList();

                if (jTokens.Count() > 1)
                {
                    throw new Exception(string.Format("Duplicated Data Key {0} in Test Data", _dataKey));
                }

                if (jTokens.Count() == 0)
                {
                    throw new Exception(string.Format("Data Key {0} does not exist", _dataKey));
                }

                var testDataJson = jTokens.First()["Data"].ToString();
                return testDataJson;
            }
        }

        public T GetTestData<T>() where T : class
        {
            string json = LoadJson();
            
            T result = JsonConvert.DeserializeObject<T>(json, new FileConverter(), new AttributeConverter());

            return result;
        }
    }
}
