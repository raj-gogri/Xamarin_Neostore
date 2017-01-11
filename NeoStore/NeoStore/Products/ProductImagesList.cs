using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    [Table("ProductImagesList")]
  public class ProductImagesList
    {
        [PrimaryKey]
        public int id { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public int ProductId { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string ProductImages { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public string Modified { get; set; }
    }
}
