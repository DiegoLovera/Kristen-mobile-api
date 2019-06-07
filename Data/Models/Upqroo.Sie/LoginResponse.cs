using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Data.Models.Upqroo.Sie
{
    public class LoginResponse
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public User User { get; set; }
    }
}
