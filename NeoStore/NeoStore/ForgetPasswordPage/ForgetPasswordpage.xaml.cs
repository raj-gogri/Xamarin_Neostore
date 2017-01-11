using NeoStore.Loginpage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.ForgetPasswordPage
{
    public partial class ForgetPasswordpage : ContentPage
    {
        public ForgetPasswordpage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A");
            lblNeoStore.TextColor = Color.FromHex("#FFFFFF");
            DoSub();
            BindingContext = new ForgetPasswordViewModel();
        }

        private void DoSub()
        {
            MessagingCenter.Subscribe<ForgetPasswordManager, string>(this, "ForgetPassword", (sender, msg) => {
                DisplayAlert("Message", msg, "ok");
            });

            MessagingCenter.Subscribe<ForgetPasswordManager>(this, "Navigate", (sender) => {
                Application.Current.MainPage = new LoginPage();
            });

            MessagingCenter.Subscribe<ForgetPasswordViewModel, string>(this, "Warning", (sender, err) =>
            {
                DisplayAlert("Warning", err, "Ok");
            });
        }
    }
}
