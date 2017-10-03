using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Entities
{
    public class Transaction
    {
        public string Id { get; set; }
        public string CardId { get; set; }
        public DateTime Created { get; set; }
        public int Amount { get; set; }
        public int RefundedAmount { get; set; }
        public int CapturedAmount { get; set; }
        public int VoidedAmount { get; set; }
        public int PendingAmount { get; set; }
        public int DisputedAmount { get; set; }
        public Card Card { get; set; }
        public string Currency { get; set; }
        public Dictionary<string,string> Custom { get; set; }
        public bool Successful { get; set; }
        public string Descriptor { get; set; }
        public Trail[] Trail { get; set; }
    }
}
