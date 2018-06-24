using App.Entities;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomationTest.Core.Helpers
{
    public class LiteDatabaseHelper : IDisposable
    {
        private LiteDatabase _db;

        public LiteDatabaseHelper()
        {
            var connectionString = new ConnectionString
            {
                Filename = ConnectionString,
                UtcDate = true
            };

            _db = new LiteDatabase(connectionString);
        }

        public string ConnectionString
        {
            get
            {
                return "demo.db";
            }
        }

        public LiteCollection<Folder> Folder
        {
            get
            {
                return _db.GetCollection<Folder>("Folder");
            }
        }

        public LiteStorage FileStorage
        {
            get
            {
                return _db.FileStorage;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
                _db = null;
            }
        }
    }

    public static class LiteDbExtension
    {
        public static byte[] GetFileData(this LiteStorage storage, string fileId)
        {
            MemoryStream stream = new MemoryStream();
            storage.Download(fileId, stream);
            byte[] data = stream.ToArray();
            return data;
        }
    }
}
