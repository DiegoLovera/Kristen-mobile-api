using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Sie
{
    public class LoginPreResponse
    {
        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}
