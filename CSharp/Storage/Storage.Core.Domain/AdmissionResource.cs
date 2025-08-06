using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Core.Domain
{
    public class AdmissionResource
    {
        public int id { get; set; }
        public AdmissionDocument admDocId { get; set; }
        public AdmissionResource admResId { get; set; }
        public Measurement mesId { get; set; }
        public int amount { get; set; }
    }
}
