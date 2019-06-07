using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class User
    {
        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("carrera")]
        public string CareerId { get; set; }

        [JsonProperty("nombre_carrera")]
        public string Career { get; set; }

        [JsonProperty("creditos")]
        public string Credits { get; set; }

        [JsonProperty("situacion")]
        public string Status { get; set; }

        [JsonProperty("pdo_ini")]
        public string InitialPeriod { get; set; }

        [JsonProperty("curp")]
        public string Curp { get; set; }

        [JsonProperty("nacimiento")]
        public string DateOfBirth { get; set; }

        [JsonProperty("direccion")]
        public string Address { get; set; }

        [JsonProperty("tel_domicilio")]
        public string Phone { get; set; }

        [JsonProperty("tel_movil")]
        public string MobilePhone { get; set; }

        [JsonProperty("correo")]
        public string Email { get; set; }

        [JsonProperty("matricula")]
        public string UserId { get; set; }

        [JsonProperty("contrasena")]
        public string UserPassowrd { get; set; }

        [JsonProperty("config")]
        public Config Config { get; set; }
    }
}
