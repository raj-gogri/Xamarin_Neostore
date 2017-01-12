using NeoStore.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Loginpage
{
    class LoginManager
    {
        IRestService restservice;
        public LoginManager(IRestService service)
        {
            restservice = service;
        }
        public async Task LoginTaskAsync(LoginViewModel loginViewModel)
        {
            string msg;
            var items = await restservice.LoginTodoAsync(loginViewModel);
            if (items == null)
            {
                msg = "User login unsuccessful.\nEmail or password is wrong.";
                MessagingCenter.Send<LoginManager, string>(this, "Login", msg);
            }
            else if (items.status == 200)
            {
                App.Database.SaveItemdb(items.data);
                msg = "Login Successfull";
                MessagingCenter.Send<LoginManager, string>(this, "Login", msg);
                Application.Current.MainPage =new NavigationPage( new ProductListPage());
            }
        }
    }
}
