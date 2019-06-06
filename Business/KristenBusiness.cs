using kristen_mobile_api.Business.Enums;
using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Kristen;
using kristen_mobile_data.Data.Models;
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

        public async Task<IEnumerable<News>> GetNewsAsync(string career, string skip)
        {
            if (string.IsNullOrEmpty(career))
            {
                career = "99";
            }
            if (string.IsNullOrEmpty(skip))
            {
                skip = "0";
            }

            string filter = "{\"fields\": {\"contenidos\": false},\"where\": {\"or\": [{\"idCarrera\": 99},{\"idCarrera\": " + career + "}]}, \"order\": \"fecha DESC\", \"skip\": " + skip.ToString() + ", \"limit\": 5 }";
            return await _apiClient.GetNewsAsync(filter);
        }

        public async Task<string> GetCalendarUrlAsync()
        {
            var response = await _apiClient.GetCalendarUrlAsync();
            return response.Contents.First().Content.Url;
        }

        public async Task<IEnumerable<Contact>> GetContactsAsync()
        {
            return await _apiClient.GetContactsAsync();
        }

        public async Task<NewsDetail> GetNewsDetailAsync(string id)
        {
            var response = await _apiClient.GetNewsContentsAsync(id);
            return ConvertToNewsDetail(response);
        }

        public async Task<IEnumerable<Notice>> GetNoticesAsync()
        {
            string filter = "{\"where\": {\"or\": [{\"idCarrera\": 99},{\"idCarrera\": 1}]}, \"order\": \"fecha DESC\", \"skip\": 0, \"limit\": 10 }";
            return await _apiClient.GetNoticesAsync(filter);
        }

        private NewsDetail ConvertToNewsDetail(PublicacionContenido toConvert)
        {
            NewsDetail response = new NewsDetail
            {
                NewsId = toConvert.NewsId,
                Url = toConvert.Url,
                Title = toConvert.Title,
                Description = toConvert.Description,
                ImageCover = toConvert.Cover,
                Categories = toConvert.Category,
                Date = toConvert.Date,
                NewsTypeId = toConvert.NewsTypeId,
                CareerId = toConvert.CareerId,
                Author = toConvert.Author,
                ContentList = ConvertToNewsDetailContents(toConvert.Contents)
            };
            return response;
        }

        private List<Content> ConvertToNewsDetailContents(IEnumerable<Contenido> toConvert)
        {
            List<Content> contents = new List<Content>();
            foreach (Contenido c in toConvert)
            {
                switch (c.ContentTypeId)
                {
                    case (int)EContentType.Text:
                        contents.Add(Content.CreateTextContent(c.Content.Text));
                        break;
                    case (int)EContentType.Image:
                        contents.Add(Content.CreateImageContent(c.Content.Alt, c.Content.Source));
                        break;
                    case (int)EContentType.Link:
                        contents.Add(Content.CreateLinkContent(c.Content.Text, c.Content.Url));
                        break;
                    case (int)EContentType.Gallery:
                        contents.Add(Content.CreateGalleryContent(c.Content.Images));
                        break;
                    case (int)EContentType.Video:
                        contents.Add(Content.CreateVideoContent(c.Content.Id, c.Content.Server));
                        break;
                    case (int)EContentType.List:
                        contents.Add(Content.CreateListContent(c.Content.Title, c.Content.HasOrder, c.Content.Elements));
                        break;
                    case (int)EContentType.Title:
                        contents.Add(Content.CreateTitleContent(c.Content.Text));
                        break;
                }
            }
            return contents;
        }
    }
}
