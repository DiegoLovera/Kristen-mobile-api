using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Kardex
    {
        [JsonProperty("nombre_mat")]
        public string Subject { get; set; }

        [JsonProperty("calificacion")]
        public string Grade { get; set; }

        [JsonProperty("cuatrimestre")]
        public string Quarter { get; set; }

        [JsonProperty("matricula")]
        public string UserId { get; set; }
    }
}
