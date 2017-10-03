using System.Collections.Generic;
using System.Threading.Tasks;
using Paylike.NETStandard.Entities;

namespace Paylike.NETStandard
{
    public interface IPaylikeClient
    {
        Task<PaylikeApiResponse<Transaction>> CaptureTransaction(string transactionId, decimal amount, string currency, string descriptor);
        Task<PaylikeApiResponse<Transaction>> CaptureTransaction(string transactionId, int amount, string currency, string descriptor);
        Task<PaylikeApiResponse<Transaction>> CreateTransaction(string merchantId, string cardId, string descriptor, string currency, decimal amountAsMajor);
        Task<PaylikeApiResponse<Transaction>> CreateTransaction(string merchantId, string cardId, string descriptor, string currency, int amountAsMinor);
        Task<PaylikeApiResponse<Transfer>> CreateTransfer(string merchantId, decimal amount, string currencyId, string token);
        Task<PaylikeApiResponse<Card>> GetCardInfo(string cardId);
        Task<PaylikeApiResponse<List<Transaction>>> GetRecentTransactions(string merchantId, int limit);
        Task<PaylikeApiResponse<Card>> SaveCard(string transactionId, string merchantId);
    }
}