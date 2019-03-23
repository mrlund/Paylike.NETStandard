using Newtonsoft.Json.Linq;
using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paylike.NETStandard.Tests
{
    public class FakeHttpMessageHandler<T> : HttpMessageHandler
    {
        private bool _isError;
        private object source;
        public FakeHttpMessageHandler(bool isError = false)
        {
            _isError = isError;
            if (isError)
            {
                source = JObject.FromObject(new ErrorResponse() { message = "Something went wrong!" });
            }
            else
            {
                source = new JObject();
                ((JObject)source).Add(typeof(T).Name.ToLower(), JToken.FromObject(Activator.CreateInstance<T>()));
            }
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var responseMessage = new HttpResponseMessage(_isError ? HttpStatusCode.BadRequest : HttpStatusCode.OK)
            {
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(source))
            };

            return await Task.FromResult(responseMessage);
        }
    }
}
