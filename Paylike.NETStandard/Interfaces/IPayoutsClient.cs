using System.Threading.Tasks;
using Paylike.NETStandard.Entities;

namespace Paylike.NETStandard.Clients
{
    public interface IPayoutsClient
    {
        Task<PaylikeApiResponse<Payout>> Create(string merchantId, decimal amount, string currencyId, string descriptor, string bic, string iban);
        Task<PaylikeApiResponse<Payout>> Get(string merchantId, string payoutId);
    }
}