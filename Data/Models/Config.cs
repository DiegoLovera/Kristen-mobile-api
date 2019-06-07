using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Config
    {
        [JsonProperty("topic_general")]
        public string GeneralTopic { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("url_base")]
        public string BaseUrl { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
