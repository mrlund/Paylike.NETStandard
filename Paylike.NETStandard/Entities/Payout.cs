using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard.Entities
{
    public class Payout
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string MerchantId { get; set; }
        public int Balance { get; set; }
        public Bank Bank { get; set; }
        public string Descriptor { get; set; }
        public bool Test { get; set; }
    }
}
