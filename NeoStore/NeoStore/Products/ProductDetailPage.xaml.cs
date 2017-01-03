using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Plugin.Connectivity.Abstractions;

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
                //MainImage.Source = image.Source;                                
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
