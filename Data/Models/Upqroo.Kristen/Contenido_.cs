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
        private string Text { get; set; }

        [JsonProperty("src")]
        private string Source { get; set; }

        [JsonProperty("alt")]
        private string Alt { get; set; }

        [JsonProperty("id")]
        private string Id { get; set; }

        [JsonProperty("servidor")]
        private string Server { get; set; }

        [JsonProperty("titulo")]
        private string Title { get; set; }

        [JsonProperty("ordenada")]
        private string HasOrder { get; set; }

        [JsonProperty("cantidad")]
        private int Quantity { get; set; }

        [JsonProperty("elementos")]
        private List<string> Elements { get; set; }

        [JsonProperty("ur")]
        private string Url { get; set; }

        [JsonProperty("imagenes")]
        private List<string> Images { get; set; }
    }
}
