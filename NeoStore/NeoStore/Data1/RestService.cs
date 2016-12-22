using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using Xamarin.Forms;
using System.Net.Http.Headers;

namespace NeoStore.Data
{
     public class RestService : IRestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
        }
        public async Task<LoginResponse> LoginTodoAsync(LoginViewModel item)
        {
            LoginResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/users/login");
            try
            {
                var json = JsonConvert.SerializeObject(item);
                IList<KeyValuePair<string, string>> formDataList = new List<KeyValuePair<string, string>>();
                formDataList.Add(new KeyValuePair<string, string>("email", item.email));
                formDataList.Add(new KeyValuePair<string, string>("password", item.password));
                var content = new FormUrlEncodedContent(formDataList);
                HttpResponseMessage response = await client.PostAsync(uri, content);
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<LoginResponse>(result);
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