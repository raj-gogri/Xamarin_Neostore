using NeoStore.Loginpage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.HomePage
{
  class HomepageRestServices : IRestServices
    {
        HttpClient client;
        public HomepageRestServices()
        {
            client = new HttpClient();
        }
        public async Task<HomeResponse> ItemDeatils()
        {
            HomeResponse Items = null;
            var request = new HttpRequestMessage(HttpMethod.Get, "http://staging.php-dev.in:8844/trainingapp/api/users/getUserData");
            var xyz = App.UserLoggedInDetails;
            var avc = xyz.AccessToken;
            
            request.Headers.Add("access_token", avc);
            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<HomeResponse>(result);
                if (Items.status == 200)
                    return Items;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@" Error {0}", ex.Message);
            }
            return Items;
        }
    }
}
