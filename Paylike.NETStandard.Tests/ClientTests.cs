using Moq;
using Moq.Protected;
using Newtonsoft.Json.Linq;
using Paylike.NETStandard.Clients;
using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Paylike.NETStandard.Tests
{
    public class ClientTests
    {
        private readonly HttpClient _httpClient;

        public ClientTests()
        {
        }
        [Fact]
        public void CanInstatiateClient()
        {
            var client = new PaylikeClient(new HttpClient());
            Assert.NotNull(client);
        }

        [Fact]
        public async Task CanDeserializeTransactionResponse()
        {
            var client = new PaylikeClient(new HttpClient(new FakeHttpMessageHandler<Transaction>()));
            var tx = await client.Transactions.Get("");
            Assert.NotNull(tx);
        }
        [Fact]
        public async Task CanDeserializeTransactionResponse_When3DSChallengeReturned()
        {
            //Example 3DS challenge response from 
            //https://github.com/paylike/sdk/blob/master/3dsecure/index.md
            var errorResponse = @"{
	                                ""code"": 30,
	                                ""message"": ""3-D Secure is required"",
	                                ""client"": true,
	                                ""merchant"": false,
	                                ""tds"": {
		                                ""url"": ""https://acs4.3dsecure.no/mdpayacs/pareq"",
		                                ""pareq"": ""<string pareq>"",
		                                ""oid"": ""52f77cb2057463e8fa81""
	                                }
                                }";
            var client = new PaylikeClient(new HttpClient(new FakeHttpMessageHandler<Transaction>(true, errorResponse)));
            var tx = await client.Transactions.Get("");
            var error = tx.GetError();
            Assert.NotNull(tx);
            Assert.False(tx.IsSuccessStatusCode);
            Assert.NotNull(error);
            Assert.Equal(30, error.code);
            Assert.Equal("<string pareq>", error.tds.pareq);
        }
        [Fact]
        public async Task CanDeserializeCardResponse()
        {
            var client = new PaylikeClient(new HttpClient(new FakeHttpMessageHandler<Card>()));
            var tx = await client.Cards.Get("");
            Assert.NotNull(tx);
        }
        [Fact]
        public async Task CanDeserializePayoutResponse()
        {
            var client = new PaylikeClient(new HttpClient(new FakeHttpMessageHandler<Payout>()));
            var tx = await client.Payouts.Create("",0,"DKK","","","");
            Assert.NotNull(tx);
        }
        [Fact]
        public async Task CanDeserializeErrorResponse()
        {
            var client = new PaylikeClient(new HttpClient(new FakeHttpMessageHandler<Payout>(true)));
            var tx = await client.Payouts.Create("", 0, "DKK", "", "", "");
            Assert.NotNull(tx);
            Assert.False(tx.IsSuccessStatusCode);
            Assert.False(string.IsNullOrEmpty(tx.ErrorMessage));
        }
    }

}
