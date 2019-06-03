using kristen_mobile_api.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Content
    { 
        public int ContentTypeId { get; set; }

        // Title type and normal text content
        public string Text { get; set; }

        // Video type content
        public string Id { get; set; }
        public string Server { get; set; }

        // List type content
        public string Title { get; set; }
        public bool Ordered { get; set; }
        public List<string> Elements { get; set; }

        // Link type content 
        public string Url { get; set; }

        // Image type content
        public string Source { get; set; }

        // Gallery type content
        public List<string> Images { get; set; }

        private Content()
        {

        }

        public static Content CreateTextContent(string text)
        {
            return new Content { ContentTypeId = (int)EContentType.Text, Text = text };
        }

        public static Content CreateImageContent(string alt, string src)
        {
            return new Content { ContentTypeId = (int)EContentType.Image, Text = alt, Source = src };
        }

        public static Content CreateLinkContent(string alt, string src)
        {
            return new Content { ContentTypeId = (int)EContentType.Link, Text = alt, Source = src };
        }

        public static Content CreateGalleryContent(List<string> images)
        {
            return new Content { ContentTypeId = (int)EContentType.Gallery, Images = images };
        }

        public static Content CreateVideoContent(string id, string server)
        {
            return new Content { ContentTypeId = (int)EContentType.Video, Id = id, Server = server };
        }

        public static Content CreateListContent(string title, bool ordered, List<string> elements)
        {
            return new Content { ContentTypeId = (int)EContentType.List, Title = title, Ordered = ordered, Elements = elements };
        }

        public static Content CreateTitleContent(string title)
        {
            return new Content { ContentTypeId = (int)EContentType.Title, Text = title };
        }
    }
}
