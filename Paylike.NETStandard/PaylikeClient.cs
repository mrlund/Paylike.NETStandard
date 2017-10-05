using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Paylike.NETStandard.Entities;
using Paylike.NETStandard.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard
{
    public class PaylikeClient : IPaylikeClient
    {
        private readonly string _privateKey;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializer _jsonSerializer;
        private readonly JsonSerializerSettings _jsonSettings;
        private readonly ILogger _logger;

        public PaylikeClient(string privateKey, ILogger<PaylikeClient> logger = null)
        {   
            if (logger != null)
            {
                _logger = logger;
            }
            _privateKey = privateKey;
            _httpClient = new HttpClient();
            //_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($":{_privateKey}"))}");
            _httpClient.BaseAddress = new Uri("https://api.paylike.io/");
            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };
            _jsonSerializer = new JsonSerializer()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };
        }
        public async Task<PaylikeApiResponse<Transaction>> CreateTransaction(string merchantId, string cardId, string descriptor, string currency, decimal amountAsMajor)
        {
            return await CreateTransaction(merchantId, cardId, descriptor, currency, amountAsMajor.ToMinorUnits(currency));
        }
        public async Task<PaylikeApiResponse<Transaction>> CreateTransaction(string merchantId, string cardId, string descriptor, string currency, int amountAsMinor)
        {
            var source = new { cardId = cardId, descriptor = descriptor, currency = currency, amount = amountAsMinor };
            var content = new StringContent(JsonConvert.SerializeObject(source, _jsonSettings), Encoding.UTF8, "application/json");
            using (var req = await _httpClient.PostAsync($"merchants/{merchantId}/transactions", content))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<Transaction>(DeserializeAndUnwrap<Transaction>(await req.Content.ReadAsStringAsync()));
                }
                return new PaylikeApiResponse<Transaction>(await HandleError(req));
            }
        }

        public async Task<PaylikeApiResponse<Transaction>> CaptureTransaction(string transactionId, decimal amount, string currency, string descriptor)
        {
            return await CaptureTransaction(transactionId, amount.ToMinorUnits(currency), currency, descriptor);
        }

        public async Task<PaylikeApiResponse<Transaction>> CaptureTransaction(string transactionId, int amount, string currency, string descriptor)
        {
            //source = new Transaction() { Amount = source.Amount, Descriptor = source.Descriptor, Currency = source.Currency, Id = source.Id };
            var source = new { Amount = amount, Currency = currency, Descriptor = descriptor };
            var content = new StringContent(JsonConvert.SerializeObject(source, _jsonSettings), Encoding.UTF8, "application/json");
            using (var req = await _httpClient.PostAsync($"transactions/{transactionId}/captures", content))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<Transaction>(DeserializeAndUnwrap<Transaction>(await req.Content.ReadAsStringAsync()));
                }
                return new PaylikeApiResponse<Transaction>(await HandleError(req));
            }
        }


        public async Task<PaylikeApiResponse<Card>> SaveCard(string transactionId, string merchantId)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { transactionId = transactionId }));
            using (var req = await _httpClient.PostAsync($"merchants/{merchantId}/cards", content))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<Card>(DeserializeAndUnwrap<Card>(await req.Content.ReadAsStringAsync()));
                }
                return new PaylikeApiResponse<Card>(await HandleError(req));
            }
        }

        public async Task<PaylikeApiResponse<Card>> GetCardInfo(string cardId)
        {
            using (var req = await _httpClient.GetAsync($"cards/{cardId}"))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<Card>(DeserializeAndUnwrap<Card>(await req.Content.ReadAsStringAsync()));
                }
                return new PaylikeApiResponse<Card>(await HandleError(req));
            }
        }

        public async Task<PaylikeApiResponse<Transfer>> CreateTransfer(string merchantId, decimal amount, string currencyId, string token)
        {
            Transfer source = new Transfer(merchantId, amount, currencyId, null, token);
            var content = new StringContent(JsonConvert.SerializeObject(source, _jsonSettings), Encoding.UTF8, "application/json");
            using (var req = await _httpClient.PostAsync("transfers", content))
            {
                if (req.IsSuccessStatusCode)
                {
                    var transfer = DeserializeAndUnwrap<Transfer>(await req.Content.ReadAsStringAsync());
                    //TODO eliminate extra GET by having Paylike return full transfer object
                    return await GetTransfer(transfer.Id);
                }
                return new PaylikeApiResponse<Transfer>(await HandleError(req));
            }
        }
        public async Task<PaylikeApiResponse<Transfer>> GetTransfer(string transferId)
        {
            using (var getReq = await _httpClient.GetAsync($"transfers/{transferId}"))
            {
                if (getReq.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<Transfer>(DeserializeAndUnwrap<Transfer>(await getReq.Content.ReadAsStringAsync()));
                }
                else
                {
                    return new PaylikeApiResponse<Transfer>(await HandleError(getReq));
                }
            }
        }

        public async Task<PaylikeApiResponse<Transfer>> ApproveTransfer(string transferId)
        {
            var content = new StringContent("");
            using (var req = await _httpClient.PostAsync($"transfers/{transferId}/approvals", content))
            {
                if (req.IsSuccessStatusCode)
                {
                    return await GetTransfer(transferId);
                }
                return new PaylikeApiResponse<Transfer>(await HandleError(req));
            }
        }

        public async Task<PaylikeApiResponse<List<Transaction>>> GetRecentTransactions(string merchantId, int limit)
        {
            using (var req = await _httpClient.GetAsync($"merchants/{merchantId}/transactions?limit={limit}"))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<List<Transaction>>(JsonConvert.DeserializeObject<List<Transaction>>(await req.Content.ReadAsStringAsync()));
                }
                return new PaylikeApiResponse<List<Transaction>>(await HandleError(req));
            }
        }

        private async Task<ErrorResponse> HandleError(HttpResponseMessage request)
        {
            var errorString = await request.Content.ReadAsStringAsync();
            if (_logger != null)
            {
                _logger.LogError(errorString);
            }
            if (string.IsNullOrEmpty(errorString))
            {
                return new ErrorResponse() { code = (int)request.StatusCode, message = request.ReasonPhrase };
            }
            return JsonConvert.DeserializeObject<ErrorResponse>(errorString, _jsonSettings);

        }

        private T DeserializeAndUnwrap<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T); 
            }
            return JObject.Parse(json)[typeof(T).Name.ToLower()].ToObject<T>(_jsonSerializer);
        }
    }
}
