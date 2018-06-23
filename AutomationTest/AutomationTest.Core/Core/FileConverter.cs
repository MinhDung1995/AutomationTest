using App.Entities;
using AutomationTest.Core.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace AutomationTest.Core.Core
{
    public class FileConverter : CustomCreationConverter<MyFile>
    {
        public override MyFile Create(Type objectType)
        {
            return new MyFile();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream 
            JObject jObject = JObject.Load(reader);

            // Create target object based on JObject 
            var target = Create(objectType);

            UpdateData(jObject);

            // Populate the object properties 
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        private JObject UpdateData(JObject jObject)
        {
            if (jObject["Data"] is JObject)
            {
                int nMB = Int32.Parse(jObject["Data"]["AutoGenerate"]["nMegaByte"].ToString());
                byte[] bytes = DataGeneratorHelper.GenerateBytes(nMB);

                jObject["Data"] = bytes;
            }

            return jObject;
        }
    }
}