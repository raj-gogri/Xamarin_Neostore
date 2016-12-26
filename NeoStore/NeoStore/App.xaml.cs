using NeoStore.RegisterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NeoStore
{
    public partial class App : Application
    {

        public static DatabaseManager dbManager { get; private set; }
        public App()
        {
            InitializeComponent();        
            dbManager = new DatabaseManager(new RestServices());
            MainPage = new NavigationPage(new MainPage());
        }
        
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
