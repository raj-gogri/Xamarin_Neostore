using NeoStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace NeoStore
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public static LoginManager Loginmanager { get; set; }
        static RegistrationDetailDatabase database;
        public App()
        {
            InitializeComponent();
            Loginmanager = new LoginManager(new RestService());
            //if (!IsUserLoggedIn) {
            //    MainPage = new LoginPage(); }
            //else {
                MainPage = new NavigationPage(new MainPage()); 
            //MainPage =new MainPage();
        }
        public static RegistrationDetailDatabase Database {
            get {
                if (database == null)
                {
                    database = new RegistrationDetailDatabase();
                }
                return database;
            }
        }
        public void ShowMainPage()
        {
            MainPage = new LoginPage();
        }

        //private  void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        //{
        //    if (!e.IsConnected)
        //    {
        //        MessagingCenter.Send<App, string>(this,"InternetConnection","No internet Connectivity");
        //    }
        //}
        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
