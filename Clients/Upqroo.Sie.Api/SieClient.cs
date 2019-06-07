using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Configuration;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Sie;
using kristen_mobile_data.Data.Models.Upqroo.Sie;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace kristen_mobile_api.Clients.Upqroo.Sie.Api
{
    public class SieClient : RestApiClientBase, ISieClient
    {
        private readonly SieApiConfig _apiConfig;
        public SieClient(IOptions<AppSettings> configuration) : base(configuration.Value.SieApiConfig.BaseAddress)
        {
            _apiConfig = configuration.Value.SieApiConfig;
        }

        public async Task<IEnumerable<Grade>> GetGradesAsync(string userId, string accessToken)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Grades}/{userId}?access_token={accessToken}").ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Grade>>(json);
        }

        public async Task<IEnumerable<Kardex>> GetKardexsAsync(string userId, string accessToken)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Kardex}/{userId}?access_token={accessToken}").ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Kardex>>(json);
        }

        public async Task<IEnumerable<Semana>> GetScheduleAsync(string userId, string accessToken)
        {
            var response = await _client.GetAsync($"{_apiConfig.BaseAddress + _apiConfig.Schedule}/{userId}?access_token={accessToken}").ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Semana>>(json);
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var request = JsonConvert.SerializeObject(loginRequest);
            var requestContent = new StringContent(request, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_apiConfig.BaseAddress + _apiConfig.User}/Login", requestContent).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (json.Contains("Error"))
            {
                var errorResponse = JsonConvert.DeserializeObject<LoginPreResponse>(json);
                return new LoginResponse() { IsSuccessful = false, ErrorMessage = errorResponse.Error.Message, User = null };
            } else
            {
                return new LoginResponse() { IsSuccessful = true, ErrorMessage = null, User = JsonConvert.DeserializeObject<User>(json) };
            }
        }
    }
}
