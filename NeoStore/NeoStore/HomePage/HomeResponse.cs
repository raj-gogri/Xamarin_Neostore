using NeoStore.Loginpage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.HomePage
{
    class HomeResponse
    {
        public int status { get; set; }
        public CombineData data { get; set; }

        [JsonProperty(PropertyName = "total_carts")]
        public int TotalCarts { get; set; }

        [JsonProperty(PropertyName = "total_orders")]
        public int orders { get; set; }
    }
       
}
