using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;
using NeoStore.Data;

namespace NeoStore
{
    public partial class MainPage : ContentPage
    {
        //MainPage main;
        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A"); 
            lblNeoStore.TextColor = Color.FromHex("#FFFFFF");
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
            //var isloggedin = (LoginResponse)BindingContex              
            if (!App.IsUserLoggedIn)
            {
                Application.Current.MainPage = new LoginPage();
            }
            else
            {
                Application.Current.MainPage = new HomePage();
            }
        }
        private async void Current_ConnectivityChanged(object sender,Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (!e.IsConnected)
            {
                await DisplayAlert("Error", "Check Internet Connection", "Ok ");
            }
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
           // Application.Current.MainPage = new NavigationPage(new LoginPage());
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
