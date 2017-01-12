using NeoStore.HomePage;
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
    class ProductListPageRestService : IProductListPageRestService
    {
        HttpClient client;
        public ProductListPageRestService()
        {
            client = new HttpClient();
        }
        public async Task<ProductListPageResponse> ProductListPageTodoAsync(ProductListPageViewModel item)
        {
            var id = MasterPage.tempId;
            
            ProductListPageResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/products/getList");
            try
            {
                var json = JsonConvert.SerializeObject(item);
                HttpResponseMessage response = await client.GetAsync(uri+ "?product_category_id="+id);
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<ProductListPageResponse>(result);
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
