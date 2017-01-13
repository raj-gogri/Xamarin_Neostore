using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.Cart
{
    public partial class BuyNow : PopupPage
    {
        public BuyNow()
        {
            InitializeComponent();
            buy.BindingContext = new BuyNowViewModel();
            DoSubscribe();
        }

        private void DoSubscribe()
        {
            MessagingCenter.Subscribe<BuyNowViewModel, string>(this, "quantValidate", (sender, err) => {

                DisplayAlert("Message", err, "Ok");               
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        protected virtual Task OnAppearingAnimationEnd()
        {
            return Content.FadeTo(0.5);
        }
        protected virtual Task OnDisappearingAnimationBegin()
        {
            return Content.FadeTo(1); ;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        protected override bool OnBackgroundClicked()
        {
            return base.OnBackgroundClicked();
        }
    }
}
