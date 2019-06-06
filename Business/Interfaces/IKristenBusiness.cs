using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Kristen;
using kristen_mobile_data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business.Interfaces
{
    public interface IKristenBusiness
    {
        Task<IEnumerable<News>> GetNewsAsync(string career, string skip);
        Task<NewsDetail> GetNewsDetailAsync(string id);
        Task<IEnumerable<Notice>> GetNoticesAsync();
        Task<string> GetCalendarUrlAsync();
        Task<IEnumerable<Contact>> GetContactsAsync();
    }
}
