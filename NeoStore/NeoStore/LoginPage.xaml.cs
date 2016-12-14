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
            
        }

        void OnTapGestureRecognizerTappedForgetPassword(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        void OnAddNewUser(object sender,EventArgs e)
        {
            //Navigation.PushAsync(new Register());
        }
    }
}
