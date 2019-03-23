using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Clients
{
    public class TransfersClient : ITransfersClient
    {
        private readonly IPaylikeClient _paylikeClient;

        public TransfersClient(IPaylikeClient paylikeClient)
        {
            _paylikeClient = paylikeClient;
        }
        public async Task<PaylikeApiResponse<Transfer>> Get(string transferId)
        {
            return await _paylikeClient.MakePaylikeApiRequest<Transfer>($"transfers/{transferId}");
        }
        public async Task<PaylikeApiResponse<Transfer>> Create(string merchantId, decimal amount, string currencyId, string token)
        {
            Transfer source = new Transfer(merchantId, amount, currencyId, null, token);
            return await _paylikeClient.MakePaylikeApiRequest<Transfer>("transfers", source);
        }
        public async Task<PaylikeApiResponse<Transfer>> Approve(string transferId)
        {
            return await _paylikeClient.MakePaylikeApiRequest<Transfer>($"transfers/{transferId}/approvals", new { });
        }



    }
}
