using Paylike.NETStandard.Entities;
using Paylike.NETStandard.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Clients
{
    public class PayoutsClient : IPayoutsClient
    {
        private readonly IPaylikeClient _paylikeClient;

        public PayoutsClient(IPaylikeClient paylikeClient)
        {
            _paylikeClient = paylikeClient;
        }

        public async Task<PaylikeApiResponse<Payout>> Get(string merchantId, string payoutId)
        {
            return await _paylikeClient.MakePaylikeApiRequest<Payout>($"merchants/{merchantId}/payouts/{payoutId}");
        }
        public async Task<PaylikeApiResponse<Payout>> Create(string merchantId, decimal amount, string currencyId, string descriptor, string bic, string iban)
        {
            var source = new { amount = amount.ToMinorUnits(currencyId), notify = true, bank = new { bic = bic, iban = iban }, descriptor = descriptor };
            return await _paylikeClient.MakePaylikeApiRequest<Payout>($"merchants/{merchantId}/payouts", source);
        }

    }
}
