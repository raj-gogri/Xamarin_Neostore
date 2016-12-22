using NeoStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace NeoStore
{
    public partial class LoginPage : ContentPage
    {
       
        public LoginPage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A");
            lblAddnewuser.BackgroundColor = Color.FromHex("9E0100");
            lblneostore.TextColor = Color.FromHex("#FFFFFF");
            DoSub();
            BindingContext = new LoginViewModel();    
             
        }
        private void DoSub()
        {
            MessagingCenter.Subscribe<App, string>(this, "InternetConnection", (sender,err) => {
                DisplayAlert("Message", err, "ok");
                MessagingCenter.Unsubscribe<App, string>(this, "Hi");
            });

            MessagingCenter.Subscribe<LoginManager, string>(this, "Login", (sender, msg) => {
                DisplayAlert("Message", msg, "ok");
                MessagingCenter.Unsubscribe<App, string>(this, "Login");
            });

                MessagingCenter.Subscribe<LoginManager>(this, "Navigate", (sender) => {
                    Application.Current.MainPage = new HomePage();  
            });

            MessagingCenter.Subscribe<LoginViewModel,string>(this, "Warning", (sender,err) =>
            {
               DisplayAlert("Warning", err, "Ok");
            });
        }
        void OnTapGestureRecognizerTappedForgetPassword(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new LoginPage());
        }
        void OnAddNewUser(object sender,EventArgs e)
        {
            //Navigation.PushAsync(new Register());
        }
    }
}
