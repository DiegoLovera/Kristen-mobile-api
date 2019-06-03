using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Configuration;
using kristen_mobile_api.Data.Models;
using kristen_mobile_data.Data.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Clients.Upqroo.Kristen.Api
{
    public class KristenClient : RestApiClientBase, IKristenClient
    {
        private readonly KristenApiConfig _apiConfig;
        public KristenClient(IOptions<AppSettings> configuration) : base(configuration.Value.KristenApiConfig.BaseAddress)
        {
            _apiConfig = configuration.Value.KristenApiConfig;
        }
        public async Task<IEnumerable<News>> GetNewsAsync(string filter)
        {
            throw new NotImplementedException();
        }

        public async Task<PublicacionContenido> GetNewsContentsAsync(string id)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Publication}/" + id).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<PublicacionContenido>(json);
        }

        public async Task<string> GetCalendarUrlAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> GetContactsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Notice>> GetNoticesAsync(string filter)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Notice}?" + filter).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Notice>>(json);
        }
    }
}
