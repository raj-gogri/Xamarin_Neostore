using Newtonsoft.Json;
using SQLite;
using System;

namespace NeoStore.HomePage
{
    
   public class ProductCategoriesResponse
    {
        
        public int id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "icon_image")]
        public string IconImage { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public string Modified { get; set; }
    }
}