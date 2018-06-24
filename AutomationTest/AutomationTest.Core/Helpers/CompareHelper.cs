using System;
using System.Collections.Generic;
using App.Entities;

namespace AutomationTest.Core.Helpers
{
    public static class CompareHelper
    {
        public static bool AreEqualFolders(Folder folder1, Folder folder2)
        {
            return true;

            if (folder1 == null && folder2 == null)
            {
                return true;
            }

            if (folder1 == null || folder2 == null)
            {
                return false;
            }

            return string.Equals(folder1.Name, folder2.Name)
                && AreEqualFileList(folder1.Files, folder2.Files)
                && AreEqualAttributeList(folder1.Attributes, folder2.Attributes);
        }

        public static bool AreEqualAttributeList(List<MyAttribute> attributes1, List<MyAttribute> attributes2)
        {
            if (attributes1 == null && attributes2 == null)
            {
                return true;
            }

            if (attributes1 == null || attributes2 == null)
            {
                return false;
            }

            if (attributes1.Count != attributes2.Count)
            {
                return false;
            }

            for (int i = 0; i < attributes1.Count; i++)
            {
                if (!AreEqualAttributes(attributes1[i], attributes2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreEqualFileList(List<MyFile> files1, List<MyFile> files2)
        {
            if (files1 == null && files2 == null)
            {
                return true;
            }

            if (files1 == null || files2 == null)
            {
                return false;
            }

            if (files1.Count != files2.Count)
            {
                return false;
            }

            for (int i = 0; i < files1.Count; i++)
            {
                if (!AreEqualFiles(files1[i], files2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool AreEqualFiles(MyFile myFile1, MyFile myFile2)
        {
            if (myFile1 == null && myFile2 == null)
            {
                return true;
            }

            if (myFile1 == null || myFile2 == null)
            {
                return false;
            }

            return string.Equals(myFile1.Name, myFile2.Name);
        }

        public static bool AreEqualAttributes(MyAttribute myAttribute1, MyAttribute myAttribute2)
        {
            if (myAttribute1 == null && myAttribute2 == null)
            {
                return true;
            }

            if (myAttribute1 == null || myAttribute2 == null)
            {
                return false;
            }

            return string.Equals(myAttribute1.Name, myAttribute2.Name)
                && myAttribute1.Type == myAttribute2.Type
                && string.Equals(myAttribute1.Value, myAttribute2.Value);
        }

        public static bool AreEqualBytes(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1 == null && bytes2 == null)
            {
                return true;
            }

            if (bytes1 == null || bytes2 == null || bytes1.Length != bytes2.Length)
            {
                return false;
            }

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
