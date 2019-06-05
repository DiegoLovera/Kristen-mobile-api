using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Contact
    {
        [JsonProperty("idContacto")]
        public string ContactId { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("correo")]
        public string Email { get; set; }
    }
}
