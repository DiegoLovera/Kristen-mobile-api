using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Clients.Upqroo.Sie.Api
{
    public class SieClient : RestApiClientBase, ISieClient
    {
        private readonly SieApiConfig _sieApiConfig;
        public SieClient(IOptions<AppSettings> configuration) : base(configuration.Value.SieApiConfig.BaseAddress)
        {
            _sieApiConfig = configuration.Value.SieApiConfig;
        }
    }
}
