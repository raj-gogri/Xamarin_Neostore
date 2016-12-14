using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore
{
    public partial class Register : ContentPage,IValidation
    {
        public Register()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E91B1A");   
                  
        }
        

        public void OnTapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Terms and Conditions", "Ok");
        }

       
        
    }
}
