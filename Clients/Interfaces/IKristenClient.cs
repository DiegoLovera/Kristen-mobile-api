using kristen_mobile_api.Data.Models;
using kristen_mobile_data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Clients.Interfaces
{
    public interface IKristenClient
    {
        Task<IEnumerable<News>> GetNewsAsync(string filter);
        Task<IEnumerable<string>> GetNoticesAsync(string filter);
        Task<IEnumerable<string>> GetContactsAsync();
        Task<string> GetCalendarUrlAsync();
        Task<PublicacionContenido> GetNewsContentsAsync(string id);
    }
}
