using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A");
            lblNeostore.TextColor = Color.FromHex("#FFFFFF");
            
        }

        async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new LoginPage());
        }
    }
}
