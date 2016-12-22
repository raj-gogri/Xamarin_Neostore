using NeoStore.ViewModel;
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
        private LoginPage loginPage;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            MessagingCenter.Subscribe<MainPageViewModel>(this, "Navigate", (sender) => {
                Navigation.PushAsync(new Register());
            });
        }

       
        //public async void OnRegisterClicked(object sender,EventArgs e)
        //{
        //  await Navigation.PushAsync(new Register());
        
        //}
    }
}
