using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Plugin.Connectivity.Abstractions;
using NeoStore.CustomView;

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
                 Command=new Command(
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
                    var star = new Label { Text = "*", };
                    star.TextColor = Color.Yellow;
                    star.FontSize = 30;
                    star.VerticalOptions = LayoutOptions.Center;
                    star.HorizontalOptions = LayoutOptions.End;
                    DetailsRating.Children.Add(star);

                    var startapGestureRecognizer = new TapGestureRecognizer {
                        Command = new Command(
                            () => {

                                Navigation.PushModalAsync(new RatingPage());
                                
                            })
                    };

                    star.GestureRecognizers.Add(startapGestureRecognizer);
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
    }
}
