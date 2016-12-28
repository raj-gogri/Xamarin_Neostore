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
    public partial class Product_List_Page : ContentPage
    {
         public Product_List_Page()
        {
            InitializeComponent();
            BindingContext = new Product_List_PageViewModel();           
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
           // listview.ItemsSource = Product_List_PageViewModel.product_list_pageresponse.data;
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
