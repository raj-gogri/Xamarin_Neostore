using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Cart
{
    public class BuyNowResponse
    {
        public int status { get; set; }
        public bool data { get; set; }
        public int total_carts { get; set; }
        public string message { get; set; }
        public string user_msg { get; set; }


    }
}
