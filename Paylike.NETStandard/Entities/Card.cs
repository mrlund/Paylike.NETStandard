using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Entities
{
    public class Card
    {
        public string Created { get; set; }
        public string Id { get; set; }
        public string Bin { get; set; }
        public string Last4 { get; set; }
        public DateTime Expiry { get; set; }
        public string Scheme { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
