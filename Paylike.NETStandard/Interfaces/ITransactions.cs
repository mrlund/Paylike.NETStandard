using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Interfaces
{
    public interface ITransactions
    {
        Task<PaylikeApiResponse<Transaction>> Get(string transactionId);
        Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, int amountAsMinor);
        Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, decimal amountAsMajor);
        Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, int amount, string currency, string descriptor);
        Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, decimal amount, string currency, string descriptor);
        Task<PaylikeApiResponse<List<Transaction>>> GetRecent(string merchantId, int limit);
        Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, int amountAsMinor);
        Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, string currency, decimal amountAsMajor);
    }
}
