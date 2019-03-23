using System.Collections.Generic;
using System.Threading.Tasks;
using Paylike.NETStandard.Clients;
using Paylike.NETStandard.Entities;
using Paylike.NETStandard.Interfaces;

namespace Paylike.NETStandard
{
    public interface IPaylikeClient
    {

        ITransactions Transactions { get; }
        IPayoutsClient Payouts { get; }
        ITransfersClient Transfers { get; }
        ICardsClient Cards { get; }
        Task<PaylikeApiResponse<T>> MakePaylikeApiRequest<T>(string urlPath, object requestObject = null) where T : class;
    }
}