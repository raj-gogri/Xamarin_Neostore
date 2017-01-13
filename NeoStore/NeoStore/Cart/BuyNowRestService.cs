using System;
using System.Threading.Tasks;
using NeoStore.Products;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NeoStore.Cart
{
    internal class BuyNowRestService:IBuyNow
    {
        HttpClient client;
        public BuyNowRestService()
        {
            client = new HttpClient();
        }

        public async Task<BuyNowResponse> BuyNowTodoAsync(BuyNowViewModel item)
        {
            BuyNowResponse Items = null;
            var request = new HttpRequestMessage(HttpMethod.Post, "http://staging.php-dev.in:8844/trainingapp/api/addToCart");
            var xyz = App.UserLoggedInDetails;
            var avc = xyz.AccessToken;

            request.Headers.Add("access_token", avc);

            var id = ProductListPage.pd;
            var name = ProductListPage.name;
            try
            {
                IList<KeyValuePair<string, string>> formDataList = new List<KeyValuePair<string, string>>();
                formDataList.Add(new KeyValuePair<string, string>("product_id", id.ToString()));
                formDataList.Add(new KeyValuePair<string, string>("quantity", (item.quantity).ToString()));
                var contents = new FormUrlEncodedContent(formDataList);
                request.Content = contents; HttpResponseMessage response = await client.SendAsync(request);

                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<BuyNowResponse>(result);
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