using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class NewsDetail
    {
        public string NewsId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageCover { get; set; }
        public string Categories { get; set; }
        public string Date { get; set; }
        public int NewsTypeId { get; set; }
        public int CareerId { get; set; }
        public string Author { get; set; }
        public List<Content> ContentList { get; set; }
    }
}
