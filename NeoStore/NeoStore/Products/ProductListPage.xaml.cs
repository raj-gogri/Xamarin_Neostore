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
        public static int pd;
        public ProductListPage()
        {
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
            InitializeComponent();           
            BindingContext = new ProductListPageViewModel();
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
            var selecteditem = (ProductListPageResponseData)e.SelectedItem;
            pd = selecteditem.id;
            var selectedpage = new ProductDetailPage { Title=selecteditem.ProductName };           
            selectedpage.BindingContext = selecteditem;
            Navigation.PushAsync(selectedpage);
        }
    }
}
