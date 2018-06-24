using System.Collections.Generic;

namespace AutomationTest.Core.Constants
{
    public static class ExceptionMessages
    {
        public static class Folder
        {
            public static readonly string InvalidName = "Name Is Invalid";
            public static readonly string InvalidNameLength = "Length Is Out Of Range";
        }

        public static class File
        {
            public static readonly string InvalidName = "Name Is Invalid";
            public static readonly string InvalidData = "Data Is Null";
        }

        public static class Attribute
        {
            public static readonly string InvalidName = "Name Is Invalid";
            public static readonly string InvalidNameLength = "Length Is Out Of Range";
        }

        public static readonly List<string> FileExceptionMessages = new List<string>
        {
            File.InvalidData,
            File.InvalidName
        };

        public static readonly List<string> FolderExceptionMessages = new List<string>
        {
            Folder.InvalidNameLength,
            Folder.InvalidName
        };

        public static readonly Dictionary<string, string> AttributeExceptionMessages = new Dictionary<string, string>
        {
            { "Invalid Name", Attribute.InvalidName },
            { "Invalid Name Length", Attribute.InvalidNameLength }
        };
    }
}
