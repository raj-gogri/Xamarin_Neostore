    using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Data
{
   public class LoginResponse
    {
        public int status { get; set; }
        public ResponseData data { get; set; }
       // public ResponseData data1 { get; set; }
        //public int status1 {
        //    get {
        //        if (status == true)
        //            return 200;
        //        else
        //            return 400;
        //    } }
        public string message { get; set; }
        public string user_msg { get; set; }
    }
}
