using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Loginpage
{
    class LoginResponse
    {
        public int status { get; set; }
        public UserDetailsResponseData data { get; set; }
        public string message { get; set; }
        public string user_msg { get; set; }
    }
}
