using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Sie
{
    public class Subject
    {
        [JsonProperty("acronimo")]
        public string ElipsedName { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("profesor")]
        public string Professor { get; set; }

        [JsonProperty("hora")]
        public string Hour { get; set; }
    }
}
