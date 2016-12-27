using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.ForgetPasswordPage
{
    class ForgetPasswordManager
    {
        IRestServiceForgetPassword restservice;

        public ForgetPasswordRestService forgetPasswordRestService;

        public ForgetPasswordManager(IRestServiceForgetPassword service)
        {
            restservice = service;
        }
        public async Task ForgetPasswordTaskAsync(ForgetPasswordViewModel item)
        {
            string msg;
            var items = await restservice.ForgetPasswordTodoAsync(item); 

            if (items == null)
            {
                msg = "Email not Valid";
                MessagingCenter.Send<ForgetPasswordManager, string>(this, "ForgetPassword", msg);
            }
            else if (items.status == 200)
            {
                msg = "Email Send";
                MessagingCenter.Send<ForgetPasswordManager, string>(this, "ForgetPassword", msg);
                MessagingCenter.Send<ForgetPasswordManager>(this, "Navigate");
            }
        }
    }
}