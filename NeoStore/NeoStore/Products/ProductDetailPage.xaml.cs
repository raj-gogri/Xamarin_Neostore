using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Plugin.Connectivity.Abstractions;
using NeoStore.CustomView;
using Rg.Plugins.Popup.Extensions;

namespace NeoStore.Products
{
    public partial class ProductDetailPage : ContentPage
    {
      
        public ProductDetailPage()
        {
            InitializeComponent();
            BindingContext = new ProductDetailPageViewModel();
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
            MessagingCenter.Subscribe<ProductDetailPageManager, ProductImagesList>(this, "Images", (sender, Product) => {
                var image = new Image { Source =Product.ProductImages};
                image.WidthRequest = 110;
                Imagelist.Children.Add(image);
                var tapGestureRecognizer = new TapGestureRecognizer {
                    Command =new Command(
                        () => {
                            MainImage.Source = image.Source;
                        })
                };
                image.GestureRecognizers.Add(tapGestureRecognizer);
            });

            MessagingCenter.Subscribe<ProductDetailPageManager, int>(this, "ProductDetailRating", (sender, rating) => 
            {
                for (int i = 0; i < rating; i++)
                {
                    var star = new AwesomeLabel { Text = FontAwesome.FAStar };
                    star.TextColor = Color.FromHex("#ddd71f") ;
                    star.FontSize = 30;
                    star.HorizontalOptions = LayoutOptions.End;
                    DetailsRating.Children.Add(star);
                }
            });

            }
        private async void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (!e.IsConnected)
            {
                await DisplayAlert("Error", "Check Internet Connection", "Ok");
            }
        }
        async void OnRateClicked(object sender, EventArgs e)
        {
            var selected = BindingContext;
            var ratingpage = new RatingPage();
            ratingpage.BindingContext = selected;
            await Navigation.PushPopupAsync(ratingpage);
        }
    }
}
