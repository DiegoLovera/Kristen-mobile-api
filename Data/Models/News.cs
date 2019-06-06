using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace kristen_mobile_data.Data.Models
{
    public class News
    {
        [JsonProperty("idPublicaciones")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("idTipos_Publicacion")]
        public string PostType { get; set; }

        [JsonProperty("titulo")]
        public string Title { get; set; }

        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("categorias")]
        public string Category { get; set; }

        [JsonProperty("portada")]
        public string CoverUrl { get; set; }

        [JsonProperty("fecha")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("idCarrera")]
        public int CareerId { get; set; }
    }
}
