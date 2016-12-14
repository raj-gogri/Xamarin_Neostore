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
        }
        public async void OnRegisterClicked(object sender,EventArgs e)
        {
          await Navigation.PushAsync(new Register());
           /*isplayAlert("hi","hi","OK");*/
        }
    }
}
