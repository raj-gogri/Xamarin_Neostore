using System;
using System.Collections.ObjectModel;

namespace NeoStore.Products
{
   class Product_List_PageResponse
    {
        public int status { get; set; }
        public Product_List_PageResponseData[] data { get; set; }
    }
}