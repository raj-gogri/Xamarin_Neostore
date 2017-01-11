using System;
using System.Collections.ObjectModel;

namespace NeoStore.Products
{
   class ProductListPageResponse
    {
        public int status { get; set; }
        public ProductListPageResponseData[] data { get; set; }
    }
}