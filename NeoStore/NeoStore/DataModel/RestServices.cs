using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoStore.ViewModel;
using Plugin.Connectivity;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

namespace NeoStore.DataModel
{
    public class RestServices : IRestServices
    {
        HttpClient client;
        public RestServices()
        {
            client = new HttpClient();
          
        }
        public async Task<RegistrationResponse> RegisterUserDetails(RegisterViewModel regDetails)
        {
            RegistrationResponse result1=null;
            
            var uri = "http://staging.php-dev.in:8844/trainingapp/api/users/register";
           
            try
            {
                IList<KeyValuePair<string, string>> formDataList = new List<KeyValuePair<string, string>>();
                formDataList.Add(new KeyValuePair<string, string>("first_name",regDetails.first_name));
                formDataList.Add(new KeyValuePair<string, string>("last_name", regDetails.last_name));
                formDataList.Add(new KeyValuePair<string, string>("email", regDetails.email));
                formDataList.Add(new KeyValuePair<string, string>("password", regDetails.password));
                formDataList.Add(new KeyValuePair<string, string>("confirm_password", regDetails.confirm_password));
                formDataList.Add(new KeyValuePair<string, string>("gender", (regDetails.gender)));                
                formDataList.Add(new KeyValuePair<string, string>("phone_no", (regDetails.phone_no).ToString()));

                var contents = new FormUrlEncodedContent(formDataList); 
               
                HttpResponseMessage response = await client.PostAsync(uri, contents);
           
                Debug.WriteLine(response.StatusCode + " content > "+await response.Content.ReadAsStringAsync());
                var aa = await response.Content.ReadAsStringAsync();
                result1 = JsonConvert.DeserializeObject<RegistrationResponse>(aa);
                return result1;
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return result1;
        }

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if(!e.IsConnected)
                MessagingCenter.Send<RestServices, string>(this,"InternetConnection","PLease Check Internet Conncetion");
        }
    }
}
