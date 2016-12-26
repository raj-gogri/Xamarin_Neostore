using NeoStore;
using Plugin.Connectivity;
using System;
using Xamarin.Forms;

namespace NeoStore.RegisterPage
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
            BackgroundColor = Color.FromHex("#E91B1A");   
                     
            DoSubscribe();
            
        }

        private void DoSubscribe()
        {
            MessagingCenter.Subscribe<RegisterViewModel,string>(this, "validate1", (sender,err) => {
                DisplayAlert("Message", err, "Ok");
            });

            MessagingCenter.Unsubscribe<RegisterViewModel, string>(this, "validate1");

            MessagingCenter.Subscribe<DatabaseManager, string>(this, "validate2", (sender, err) => {
                DisplayAlert("Message", err, "Ok");
                Application.Current.MainPage = new LoginPage();
            });

            MessagingCenter.Unsubscribe<DatabaseManager,string>(this,"validate2");
            
            MessagingCenter.Subscribe<RegisterViewModel, string>(this, "InternetConnection", (sender, err) => {
                DisplayAlert("Message", err, "Ok");
            });

            MessagingCenter.Unsubscribe<RegisterViewModel, string>(this, "InternetConnection");
        }

        public void OnTapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Terms and Conditions", "Ok");
        }
    }
}
