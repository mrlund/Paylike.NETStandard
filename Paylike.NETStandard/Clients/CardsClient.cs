using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Clients
{
    public class CardsClient : ICardsClient
    {
        private readonly IPaylikeClient _paylikeClient;

        public CardsClient(IPaylikeClient paylikeClient)
        {
            _paylikeClient = paylikeClient;
        }
        public async Task<PaylikeApiResponse<Card>> Get(string cardId)
        {
            return await _paylikeClient.MakePaylikeApiRequest<Card>($"cards/{cardId}");
        }
        public async Task<PaylikeApiResponse<Card>> Save(string transactionId, string merchantId)
        {
            var source = new { transactionId = transactionId };
            return await _paylikeClient.MakePaylikeApiRequest<Card>($"merchants/{merchantId}/cards", source);
        }

    }
}
