using App.Entities;
using AutomationTest.Core.Helpers;
using LiteDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Script
{
    [TestClass]
    public class CleanupTest
    {
        [AssemblyInitialize()]
        public static void AutomationTestIntialize(TestContext testContext)
        {
            // Clear Data In Db
            ClearData();

            Debug.WriteLine("1st");
        }

        [AssemblyCleanup]
        public static void AutomationTestCleanup()
        {
            // Clear Data In Db
            ClearData();

            Debug.WriteLine("save the best for the last");
        }

        public static void ClearData()
        {
            string path;
            using (LiteDatabaseHelper db = new LiteDatabaseHelper())
            {
                path = db.ConnectionString;
            }

            File.Delete(path);
        }
    }
}
