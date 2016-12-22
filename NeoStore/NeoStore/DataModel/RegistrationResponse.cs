using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.DataModel
{
    public class RegistrationResponse
    {
        public bool Status { get; set; }
        public int stat
        {
            get
            {
                if (Status == true)
                    return 200;
                else
                    return 400;
            }
        }
        public string MEssage { get; set; }
        public string User_Msg { get; set; }
        public ResponseData Data { get; set; }
    }
}
