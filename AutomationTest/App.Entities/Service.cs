using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Service
    {
        public Folder GetFolder(Guid id)
        {
            return new Folder();
        }

        public Folder SaveFolder(Folder folder, Guid originId)
        {
            return new Folder();
        }
    }
}
