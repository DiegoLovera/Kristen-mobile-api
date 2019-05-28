using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Kristen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business
{
    public class KristenBusiness : IKristenBusiness
    {
        private readonly IKristenClient _apiClient;
        public KristenBusiness(IKristenClient kristenClient)
        {
            _apiClient = kristenClient;
        }

        public async Task<NewsDetail> GetNewsDetailAsync(string id)
        {
            var response = await _apiClient.GetNewsContentsAsync(id);
            return ConvertToNewsDetail(response);
        }

        private NewsDetail ConvertToNewsDetail(PublicacionContenido toConvert)
        {
            NewsDetail response = new NewsDetail();
            response.NewsDetailContent = ConvertToNewsDetailContents(toConvert.Contenido);
            return response;
        }

        private List<NewsDetailContent> ConvertToNewsDetailContents(IEnumerable<Contenido> toConvert)
        {
            throw new NotImplementedException();
        }
    }
}
