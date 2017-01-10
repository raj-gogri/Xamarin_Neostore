using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    public class RatingPageRestService:IRatingPage
    {
        HttpClient client;
        public RatingPageRestService()
        {
            client = new HttpClient();
        }
        public async Task<ProductDetailPageResponse> RatingPageTodoAsync(RatingPageViewModel item)
        {
            ProductDetailPageResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/products/setRating");
            var id = ProductListPage.pd;
            var rating = RatingPageViewModel.ratingpageviewmodelrating;
            try
            {
                var json = JsonConvert.SerializeObject(item);
                HttpResponseMessage response = await client.GetAsync(uri + "?product_id=" + id + "?rating=" + rating);
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