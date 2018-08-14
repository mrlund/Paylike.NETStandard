using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Entities
{
    public class Trail
    {
        public Fee Fee { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }
        public DateTime Created { get; set; }
        public bool Capture { get; set; }
        public bool Refund { get; set; }
        public string Descriptor { get; set; }
    }
}
