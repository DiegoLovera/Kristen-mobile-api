using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Kristen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business.Interfaces
{
    public interface IKristenBusiness
    {
        Task<NewsDetail> GetNewsDetailAsync(string id);
    }
}
