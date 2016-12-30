using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    internal class ProductDetailsPageRestService : IProductDetailPageRestService
    {
        HttpClient client;

        public ProductDetailsPageRestService()
        {
            client = new HttpClient();
        }
        public async Task<ProductDetailPageResponse> ProductDetailsPageTodoAsync(ProductDetailPageViewModel item)
        {
            ProductDetailPageResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/products/getDetail");
            try
            {
                var json = JsonConvert.SerializeObject(item);
                HttpResponseMessage response = await client.GetAsync(uri + "?product_id=1");
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<ProductDetailPageResponse>(result);
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