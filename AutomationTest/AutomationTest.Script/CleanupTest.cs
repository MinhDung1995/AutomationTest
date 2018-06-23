using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.WriteLine("1st");
        }

        [AssemblyCleanup]
        public static void AutomationTestCleanup()
        {
            // Clear Data In Db
            Debug.WriteLine("save the best for the last");
        }
    }
}
