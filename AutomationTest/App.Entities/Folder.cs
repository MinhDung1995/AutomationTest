using System;
using System.Collections.Generic;

namespace App.Entities
{
    public class Folder
    {
        public Guid Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string Name { get; set; }

        public List<MyFile> Files { get; set; }

        public List<MyAttribute> Attributes { get; set; }

        public Folder()
        {
            Files = new List<MyFile>();
            Attributes = new List<MyAttribute>();
        }
    }
}
