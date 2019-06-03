using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Kristen
{
    public class Contenido_
    {
        [JsonProperty("texto")]
        public string Text { get; set; }

        [JsonProperty("src")]
        public string Source { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("servidor")]
        public string Server { get; set; }

        [JsonProperty("titulo")]
        public string Title { get; set; }

        [JsonProperty("ordenada")]
        public bool HasOrder { get; set; }

        [JsonProperty("cantidad")]
        public int Quantity { get; set; }

        [JsonProperty("elementos")]
        public List<string> Elements { get; set; }

        [JsonProperty("ur")]
        public string Url { get; set; }

        [JsonProperty("imagenes")]
        public List<string> Images { get; set; }
    }
}
