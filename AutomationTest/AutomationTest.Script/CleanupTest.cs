using App.Entities;
using LiteDB;
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
            LiteDatabase db = new LiteDatabase("demo.db");
            db.GetCollection<Folder>("Data").Delete(x => x.CreatedDateTime < DateTime.Now);
            List<LiteFileInfo> infoList = db.FileStorage.FindAll().ToList();
            infoList.ForEach(info =>
            {
                db.FileStorage.Delete(info.Id);
            });

            int count = db.GetCollection<Folder>("Data").Count();
            Debug.WriteLine("1st - " + count);
        }

        [AssemblyCleanup]
        public static void AutomationTestCleanup()
        {
            // Clear Data In Db
            LiteDatabase db = new LiteDatabase("demo.db");
            int countBefore = db.GetCollection<Folder>("Data").Count();

            db.GetCollection<Folder>("Data").Delete(x => x.CreatedDateTime < DateTime.Now);
            List<LiteFileInfo> infoList = db.FileStorage.FindAll().ToList();
            infoList.ForEach(info =>
            {
                db.FileStorage.Delete(info.Id);
            });

            int countAfter = db.GetCollection<Folder>("Data").Count();
            Debug.WriteLine("save the best for the last - " + countBefore + "-" + countAfter);
        }
    }
}
