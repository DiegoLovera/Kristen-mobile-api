using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace kristen_mobile_data.Data.Models.Upqroo.Sie
{
    public class LoginRequest
    {
        [JsonProperty("matricula")]
        public string StudentId { get; set; }

        [JsonProperty("contrasena")]
        public string StudentPassword { get; set; }
    }
}
