using kristen_mobile_api.Business.Exceptions;
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
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Publication}?filter=" + Uri.EscapeUriString(filter)).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiRequestException(response.StatusCode);
            }
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<News>>(json);
        }

        public async Task<PublicacionContenido> GetNewsContentsAsync(string id)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Publication}/" + id).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiRequestException(response.StatusCode);
            }
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<PublicacionContenido>(json);
        }

        public async Task<PublicacionContenido> GetCalendarUrlAsync()
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.InstitutionalInformation}/findOne?filter=%7B%22where%22%3A%7B%22idTipos_Informacion%22%3A10%7D%2C%22fields%22%3A%7B%22contenidos%22%3Atrue%7D%7D").ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiRequestException(response.StatusCode);
            }
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<PublicacionContenido>(json);
        }

        public async Task<IEnumerable<Contact>> GetContactsAsync()
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Contacts}/").ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiRequestException(response.StatusCode);
            }
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Contact>>(json);
        }

        public async Task<IEnumerable<Notice>> GetNoticesAsync(string filter)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Notice}?" + filter).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiRequestException(response.StatusCode);
            }
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Notice>>(json);
        }
    }
}
