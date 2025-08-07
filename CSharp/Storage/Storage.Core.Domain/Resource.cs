using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Core.Domain
{
    public class Resource
    {
        public int resId { get; set; }
        public string name { get; set; }
        public bool isArchive { get; set; }
    }
}
