using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Sie
{
    public class Week
    {
        [JsonProperty("Lunes")]
        public IEnumerable<Subject> Monday { get; set; }

        [JsonProperty("Martes")]
        public IEnumerable<Subject> Tuesday { get; set; }

        [JsonProperty("Miercoles")]
        public IEnumerable<Subject> Wednesday { get; set; }

        [JsonProperty("Jueves")]
        public IEnumerable<Subject> Thursday { get; set; }

        [JsonProperty("Viernes")]
        public IEnumerable<Subject> Friday { get; set; }
    }
}
