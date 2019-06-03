using kristen_mobile_api.Data.Models.Upqroo.Kristen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class PublicacionContenido
    {
        [JsonProperty("idPublicaciones")]
        public string NewsId;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("titulo")]
        public string Title;

        [JsonProperty("descripcion")]
        public string Description;

        [JsonProperty("portada")]
        public string Cover;

        [JsonProperty("categorias")]
        public string Category;

        [JsonProperty("fecha")]
        public string Date;

        [JsonProperty("idTipos_Publicacion")]
        public int NewsTypeId;

        [JsonProperty("idUsuarios")]
        public string UsersId;

        [JsonProperty("idCarrera")]
        public int CareerId;

        [JsonProperty("autor")]
        public string Author;

        [JsonProperty("contenidos")]
        public List<Contenido> Contents;
    }
}
