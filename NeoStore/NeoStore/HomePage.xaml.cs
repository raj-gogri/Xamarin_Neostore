using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

       void OnLogOutClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            App.Current.MainPage = new LoginPage();
        }
    }
}
