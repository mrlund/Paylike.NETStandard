using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Entities
{
    public class Fee
    {
        public int Flat { get; set; }
        public int Rate { get; set; }
    }
}
