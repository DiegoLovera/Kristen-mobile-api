using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace kristen_mobile_api.Clients
{
    public abstract class RestApiClientBase
    {
        protected HttpClient _client;

        protected RestApiClientBase(string baseAddress)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress ?? "")
            };
        }
    }
}
