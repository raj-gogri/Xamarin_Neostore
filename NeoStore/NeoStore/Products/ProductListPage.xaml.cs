using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.Products
{
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
            BindingContext = new ProductListPageViewModel();
            //var list = new Product_List_PageViewModel();
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
        }                
        private async void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (!e.IsConnected)
            {
                await DisplayAlert("Error", "Check Internet Connection", "Ok");
            }
        }

        void ProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var productselected = (ProductListPageResponseData)e.SelectedItem;
            var selectedpage = new ProductDetailPage();
            selectedpage.BindingContext = productselected;
            Navigation.PushAsync(selectedpage);
        }
    }
}
