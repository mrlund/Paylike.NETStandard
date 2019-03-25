using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Paylike.NETStandard.Clients;
using Paylike.NETStandard.Entities;
using Paylike.NETStandard.Interfaces;
using Paylike.NETStandard.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NETStandard
{
    public class PaylikeClient : IPaylikeClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializer _jsonSerializer;
        private readonly JsonSerializerSettings _jsonSettings;
        private readonly ILogger _logger;

        private readonly ITransactions _transactions;
        private readonly IPayoutsClient _payouts;
        private readonly ITransfersClient _transfers;
        private readonly ICardsClient _cards;

        public ITransactions Transactions { get { return _transactions;  } }
        public IPayoutsClient Payouts { get { return _payouts;  } }
        public ITransfersClient Transfers { get { return _transfers;  } }
        public ICardsClient Cards { get { return _cards;  } }

        public PaylikeClient(HttpClient httpClient, string privateKey = null, ILogger<PaylikeClient> logger = null)
        {   
            _httpClient = httpClient ?? throw new NullReferenceException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri("https://api.paylike.io/");

            if (logger != null)
            {
                _logger = logger;
            }

            if (privateKey != null)
            {
                SetPrivateKeyForRequests(privateKey);
            }

            _transactions = new TransactionsClient(this);
            _payouts = new PayoutsClient(this);
            _transfers = new TransfersClient(this);
            _cards = new CardsClient(this);
            

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
        public void SetPrivateKeyForRequests(string privateKey)
        {
            _httpClient.DefaultRequestHeaders.Remove("Authorization");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($":{privateKey}"))}");
        }

        public async Task<PaylikeApiResponse<T>> MakePaylikeApiRequest<T>(string urlPath, object requestObject = null) where T : class
        {
            using (var req = requestObject == null ?
                await _httpClient.GetAsync(urlPath)
                : await _httpClient.PostAsync(urlPath, new StringContent(JsonConvert.SerializeObject(requestObject, _jsonSettings), Encoding.UTF8, "application/json")))
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PaylikeApiResponse<T>(DeserializeAndUnwrap<T>(await req.Content.ReadAsStringAsync()));
                }

                return new PaylikeApiResponse<T>(await HandleError(req));
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
            var token = JToken.Parse(errorString);
            if (token is JArray)
            {
                return JsonConvert.DeserializeObject<List<ErrorResponse>>(errorString, _jsonSettings).FirstOrDefault();
            } else
            {
                return JsonConvert.DeserializeObject<ErrorResponse>(errorString, _jsonSettings);
            }

        }

        private T DeserializeAndUnwrap<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return default(T); 
            }
            if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(List<>))
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            return JObject.Parse(json)[typeof(T).Name.ToLower()].ToObject<T>(_jsonSerializer);
        }


    }
}
