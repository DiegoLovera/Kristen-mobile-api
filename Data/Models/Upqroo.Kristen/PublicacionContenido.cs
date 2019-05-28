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
        private string NewsId;

        [JsonProperty("url")]
        private string Url;

        [JsonProperty("titulo")]
        private string Title;

        [JsonProperty("descripcion")]
        private string Description;

        [JsonProperty("portada")]
        private string Cover;

        [JsonProperty("categorias")]
        private string Category;

        [JsonProperty("fecha")]
        private string Date;

        [JsonProperty("idTipos_Publicacion")]
        private int NewsTypeId;

        [JsonProperty("idUsuarios")]
        private string UsersId;

        [JsonProperty("idCarrera")]
        private int CareerId;

        [JsonProperty("autor")]
        private string Author;

        [JsonProperty("contenidos")]
        private List<Contenido> Contents;
    }
}
