using NeoStore.CustomView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            var rating = StarRatingContentView.x;
            try
            {
                var json = JsonConvert.SerializeObject(item);
                IList<KeyValuePair<string, string>> formDataList = new List<KeyValuePair<string, string>>();
                formDataList.Add(new KeyValuePair<string, string>("product_id", id.ToString()));
                formDataList.Add(new KeyValuePair<string, string>("rating", rating.ToString()));
                var content = new FormUrlEncodedContent(formDataList);
                HttpResponseMessage response = await client.PostAsync(uri,content);
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