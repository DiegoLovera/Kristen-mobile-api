using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Sie;
using kristen_mobile_data.Data.Models.Upqroo.Sie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business
{
    public class SieBusiness : ISieBusiness
    {
        private readonly ISieClient _apiClient;
        public SieBusiness(ISieClient sieClient)
        {
            _apiClient = sieClient;
        }

        public async Task<IEnumerable<Grade>> GetGradesAsync(string userId, string accessToken)
        {
            return await _apiClient.GetGradesAsync(userId, accessToken);
        }

        public async Task<IEnumerable<Kardex>> GetKardexsAsync(string userId, string accessToken)
        {
            return await _apiClient.GetKardexsAsync(userId, accessToken);
        }

        public async Task<IEnumerable<SchoolDay>> GetScheduleAsync(string userId, string accessToken)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            return await _apiClient.LoginAsync(request);
        }
    }
}
