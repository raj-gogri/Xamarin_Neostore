﻿using Newtonsoft.Json;
using SQLite;
using System;

namespace NeoStore.Products
{
    [Table("ProductResponse")]
    public class ProductListPageResponseData
    {
        [PrimaryKey]
        public int id { get; set; }

        [JsonProperty(PropertyName = "product_category_id")]
        public int ProductCategoryId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string ProductName { get; set; } 

        [JsonProperty(PropertyName = "producer")]
        public string ProducerName { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public float Rating { get; set; }

        [JsonProperty(PropertyName = "view_count")]
        public int ViewCount { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public DateTime Modified { get; set; }

        [JsonProperty(PropertyName = "product_images")]
        public string ProductImages { get; set; }


    }
}