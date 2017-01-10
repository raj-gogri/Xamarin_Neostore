using NeoStore.CustomView;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace NeoStore.Products
{
    public partial class RatingPage : PopupPage
    {
        public RatingPage()
        {
            InitializeComponent();
            rate.BindingContext = new RatingPageViewModel();
            //BindingContext = new RatingPageViewModel();
            var star = new StarRatingContentView { OutOffRated = 5, Rating =  0 };
            DetailsRating.Children.Add(star);
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
