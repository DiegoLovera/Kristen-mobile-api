using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models
{
    public class Grade
    {
        [JsonProperty("grupo")]
        public string Code { get; set; }

        [JsonProperty("nombre_mat")]
        public string Subject { get; set; }

        [JsonProperty("calificacion")]
        public string GeneralGrade { get; set; }

        [JsonProperty("parcial_1")]
        public string GradeOne { get; set; }

        [JsonProperty("parcial_2")]
        public string GradeTwo { get; set; }

        [JsonProperty("parcial_3")]
        public string GradeThree { get; set; }

        [JsonProperty("parcial_4")]
        public string GradeFour { get; set; }

        [JsonProperty("parcial_5")]
        public string GradeFive { get; set; }

        [JsonProperty("matricula")]
        public string UserId { get; set; }
    }
}
