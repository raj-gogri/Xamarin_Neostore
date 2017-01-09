using NeoStore.HomePage;
using NeoStore.Loginpage;
using NeoStore.RegisterPage;
using System;
using Xamarin.Forms;

namespace NeoStore.Loginpage
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A");
            lblAddnewuser.BackgroundColor = Color.FromHex("#9E0100");
            //lblneostore.TextColor = Color.FromHex("#FFFFFF");
            DoSub();
            BindingContext = new LoginViewModel();
        }

        private void DoSub()
        {
            MessagingCenter.Subscribe<App, string>(this, "InternetConnection", (sender, err) => {
                DisplayAlert("Message", err, "ok");
               // MessagingCenter.Unsubscribe<App, string>(this, "Hi");
            });

            MessagingCenter.Subscribe<LoginManager, string>(this, "Login", (sender, msg) => {
                DisplayAlert("Message", msg, "ok");              
            });
               // MessagingCenter.Unsubscribe<LoginManager, string>(this, "Login");

            MessagingCenter.Subscribe<LoginManager>(this, "Navigate", (sender) => {


                App.Current.MainPage = ( new Homepage());
            });

            MessagingCenter.Subscribe<LoginViewModel, string>(this, "Warning", (sender, err) =>
            {
                DisplayAlert("Warning", err, "Ok");
            });
            //MessagingCenter.Unsubscribe<LoginViewModel, string>(this, "Warning");
        }
        void OnTapGestureRecognizerTappedForgetPassword(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new ForgetPasswordPage());
        }
        void OnAddNewUser(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}
