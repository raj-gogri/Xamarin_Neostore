using NeoStore.DataModel;
using NeoStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore
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

            MessagingCenter.Subscribe<DatabaseManager, string>(this, "validate2", (sender, err) => {
                DisplayAlert("Message", err, "Ok");
                Application.Current.MainPage = new LoginPage();
            });
            
            MessagingCenter.Subscribe<RestServices, string>(this, "InternetConnection", (sender, err) => {
                DisplayAlert("Message", err, "Ok");
            });
        }

        public void OnTapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Terms and Conditions", "Ok");
        }
    }
}
