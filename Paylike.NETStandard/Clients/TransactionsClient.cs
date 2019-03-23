using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Paylike.NETStandard.Entities;
using Paylike.NETStandard.Interfaces;
using Paylike.NETStandard.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Clients
{
    public class TransactionsClient : ITransactions
    {
        private readonly IPaylikeClient _paylikeClient; 

        public TransactionsClient(IPaylikeClient paylikeClient) 
        {
            _paylikeClient = paylikeClient;
        }
        public async Task<PaylikeApiResponse<Transaction>> Get(string transactionId)
        {
            return await _paylikeClient.MakePaylikeApiRequest<Transaction>($"transactions/{transactionId}");
        }
        public async Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, int amountAsMinor)
        {
            var source = new { cardId = cardId, descriptor = descriptor, currency = currency, amount = amountAsMinor };
            return await _paylikeClient.MakePaylikeApiRequest<Transaction>($"merchants/{merchantId}/transactions", source);
        }
        public async Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, decimal amountAsMajor)
        {
            return await Create(merchantId, cardId, descriptor, currency, amountAsMajor.ToMinorUnits(currency));
        }
        public async Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, int amount, string currency, string descriptor)
        {
            var source = new { Amount = amount, Currency = currency, Descriptor = descriptor };
            return await _paylikeClient.MakePaylikeApiRequest<Transaction>($"transactions/{transactionId}/captures", source);
        }
        public async Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, decimal amount, string currency, string descriptor)
        {
            return await Capture(transactionId, amount.ToMinorUnits(currency), currency, descriptor);
        }

        public async Task<PaylikeApiResponse<List<Transaction>>> GetRecent(string merchantId, int limit)
        {
            return await _paylikeClient.MakePaylikeApiRequest<List<Transaction>>($"merchants/{merchantId}/transactions?limit={limit}");
        }
        public async Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, int amountAsMinor)
        {
            var source = new { descriptor = descriptor, amount = amountAsMinor };
            return await _paylikeClient.MakePaylikeApiRequest<Transaction>($"transactions/{transactionId}/refunds", source);
        }
        public async Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, string currency, decimal amountAsMajor)
        {
            return await Refund(transactionId, descriptor, amountAsMajor.ToMinorUnits(currency));
        }

    }
}
