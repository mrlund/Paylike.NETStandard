using Newtonsoft.Json;
using Paylike.NETCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard.Entities
{
    public class Transfer
    {
        public string Id { get; set; }
        public DateTime? Created { get; set; }
        public bool? Test { get; set; }
        public string IdentityId { get; set; }
        public Source Source { get; set; }
        public Destination Destination { get; set; }
        public string Currency { get; set; }
        public int Amount { get; set; }
        public Object Custom { get; set; }
        public bool? Approved { get; set; }
        public bool? Processed { get; set; }

        public Transfer()
        {

        }
        public Transfer(string sourceMerchantId, decimal amount, string currencyId, string destinationMerhantId, string destinationCardId)
        {
            Amount = amount.ToMinorUnits(currencyId);
            Destination = new Destination() { CardId = destinationCardId, MerchantId = destinationMerhantId };
            Source = new Source() { MerchantId = sourceMerchantId };
            Currency = currencyId;
        }

    }

    public class Source
    {
        public string MerchantId { get; set; }
        public string Currency { get; set; }
        public int? Amount { get; set; }
        public Fee Fee { get; set; }
        public string LineId { get; set; }
    }

    public class Destination
    {
        public string CardId { get; set; }
        public string TransactionId { get; set; }
        public string MerchantId { get; set; }
        public Bank Bank { get; set; }
        public string Text { get; set; }
    }

}
