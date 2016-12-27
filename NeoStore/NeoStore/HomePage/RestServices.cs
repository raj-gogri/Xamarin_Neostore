using NeoStore.RegisterPage;
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
    public class RestServices : IRestServices
    {
        HttpClient client;
       RegistrationResponse reg;
        public RestServices()
        {
            client = new HttpClient();
        }
        public async Task<HomePageResponse> RegisterUserDetails(HomepageModelView regResponse)
        {
           
            RegistrationResponse result1 = null;

            var uri = "http://staging.php-dev.in:8844/trainingapp/api/users/getUserData";

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri + " " + reg.UserData.AccessToken);               
                var aa = await response.Content.ReadAsStringAsync();
                result1 = JsonConvert.DeserializeObject<HomePageResponse>(aa);               
                return result1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return result1;
        }
    }
}
