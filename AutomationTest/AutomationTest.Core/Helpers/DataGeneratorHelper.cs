using Newtonsoft.Json.Linq;
using System;

namespace AutomationTest.Core.Helpers
{
    public static class DataGeneratorHelper
    {
        public static byte[] GenerateBytes(int nMB)
        {
            if (nMB <= 0)
            {
                return new byte[0];
            }

            Random rnd = new Random();
            int nBytes = nMB * 1024 * 1024;
            byte[] bytes = new byte[nBytes];
            rnd.NextBytes(bytes);

            return bytes;
        }

        public static string GenerateJsonString(int nMB)
        {
            if (nMB <= 0)
            {
                return string.Empty;
            }

            int nBytes = nMB * 1024 * 1024;
            JObject jObject = new JObject();
            jObject.Add("Data", new string('X', nBytes));

            return jObject.ToString();
        }

        public static string GenerateString(char charater, int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }

            return new string(charater, length);
        }
    }
}
