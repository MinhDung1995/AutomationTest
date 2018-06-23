using App.Entities;
using AutomationTest.Core.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace AutomationTest.Core.Core
{
    public class AttributeConverter : CustomCreationConverter<MyAttribute>
    {
        public override MyAttribute Create(Type objectType)
        {
            return new MyAttribute();
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
            if (jObject["Value"] is JObject)
            {
                int nMB = Int32.Parse(jObject["Value"]["AutoGenerate"]["nMegaByte"].ToString());

                jObject["Value"] = DataGeneratorHelper.GenerateJsonString(nMB);
            }

            if (jObject["Name"] is JObject)
            {
                int length = Int32.Parse(jObject["Name"]["AutoGenerate"]["Length"].ToString());

                jObject["Name"] = new string('X', length);
            }

            return jObject;
        }
    }
}