using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Data
{
   public class LoginManager
    {
        IRestService restservice;
        public LoginManager(IRestService service)
        {
            restservice = service;
        }
        public async Task LoginTaskAsync(LoginViewModel item)
        {
            string msg;
            var items = await restservice.LoginTodoAsync(item);

            if (items== null)
            {
                msg = "User login unsuccessful.\nEmail or password is wrong.";
                MessagingCenter.Send<LoginManager, string>(this, "Login", msg);
            }
            
            else if(items.status == 200)
            {
                App.IsUserLoggedIn = true;
                msg = "Login Successfull";
                MessagingCenter.Send<LoginManager, string>(this, "Login", msg);
                MessagingCenter.Send<LoginManager>(this, "Navigate");
            }     
        }   
    }
}
