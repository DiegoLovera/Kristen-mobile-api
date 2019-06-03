using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Kristen
{
    public class Contenido
    {
        [JsonProperty("idTipoContenidos")]
        public int ContentTypeId { get; set; }

        [JsonProperty("contenido")]
        public Contenido_ Content { get; set; }
    }
}
