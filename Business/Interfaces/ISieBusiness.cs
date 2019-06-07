using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Sie;
using kristen_mobile_data.Data.Models.Upqroo.Sie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business.Interfaces
{
    public interface ISieBusiness
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<IEnumerable<Grade>> GetGradesAsync(string userId, string accessToken);
        Task<IEnumerable<Kardex>> GetKardexsAsync(string userId, string accessToken);
        Task<IEnumerable<SchoolDay>> GetScheduleAsync(string userId, string accessToken);
    }
}
