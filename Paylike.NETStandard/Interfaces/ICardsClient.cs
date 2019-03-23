using System.Threading.Tasks;
using Paylike.NETStandard.Entities;

namespace Paylike.NETStandard.Clients
{
    public interface ICardsClient
    {
        Task<PaylikeApiResponse<Card>> Get(string cardId);
        Task<PaylikeApiResponse<Card>> Save(string transactionId, string merchantId);
    }
}