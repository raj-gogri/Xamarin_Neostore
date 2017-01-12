using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeoStore.ForgetPasswordPage
{
    class ForgetPasswordRestService: IRestServiceForgetPassword
    {
        HttpClient client;
        public ForgetPasswordRestService()
        {
            client = new HttpClient();
        }

        public async Task<ForgetPasswordResponse> ForgetPasswordTodoAsync(ForgetPasswordViewModel item)
        {
            ForgetPasswordResponse Items = null;
            var uri = new Uri("http://staging.php-dev.in:8844/trainingapp/api/users/forgot");
            try
            {
                var json = JsonConvert.SerializeObject(item);
                IList<KeyValuePair<string, string>> formDataList = new List<KeyValuePair<string, string>>();
                formDataList.Add(new KeyValuePair<string, string>("email", item.email));
                var content = new FormUrlEncodedContent(formDataList);
                HttpResponseMessage response = await client.PostAsync(uri, content);
                var result = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<ForgetPasswordResponse>(result);
                //if (Items.status == 200)
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