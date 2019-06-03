using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Notice
    {
        [JsonProperty("idAvisos")]
        public string NoticeId { get; set; }

        [JsonProperty("titulo")]
        public string Title { get; set; }

        [JsonProperty("cuerpo")]
        public string Body { get; set; }

        [JsonProperty("fecha")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("idUsuarios")]
        public string UserId { get; set; }

        [JsonProperty("idCarrera")]
        public int CareerId { get; set; }
    }
}
