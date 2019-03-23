using System.Threading.Tasks;
using Paylike.NETStandard.Entities;

namespace Paylike.NETStandard.Clients
{
    public interface ITransfersClient
    {
        Task<PaylikeApiResponse<Transfer>> Approve(string transferId);
        Task<PaylikeApiResponse<Transfer>> Create(string merchantId, decimal amount, string currencyId, string token);
        Task<PaylikeApiResponse<Transfer>> Get(string transferId);
    }
}