using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    class Product_List_PageRestService : IProduct_List_PageRestService
    {
        HttpClient client;
        public Product_List_PageRestService()
        {
            client = new HttpClient();
        }
        public async Task<Product_List_PageResponse> Product_List_PageTodoAsync(Product_List_PageViewModel item)
        {
            Product_List_PageResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/products/getList");
            try
            {
                var json = JsonConvert.SerializeObject(item);
                HttpResponseMessage response = await client.GetAsync(uri+ "?product_category_id=1");
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<Product_List_PageResponse>(result);
                if (Items.status == 200)
                    return Items;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@" Error {0}", ex.Message);
            }
            return Items;
        }
    }
}
