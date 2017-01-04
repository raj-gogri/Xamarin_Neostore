using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace NeoStore.Products
{
    class ProductDetailPageViewModel: INotifyPropertyChanged
    {
        public static ProductDetailPageResponse rp { get; set; }
        private string productname;
        private string producername;
        private int cost;
        public string description;
        private bool isLoading;
        public bool IsLoading
        {
            get
            {
                return this.isLoading;
            }

            set
            {
                this.isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }

        private void RaisePropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public string ProductName
        {
            get { return productname; }
            set
            {
                productname = rp.data.ProductName; 
                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("ProductName"));
                    }
            }
        }
        public string ProducerName
        {
            get { return producername; }
            set
            {
                producername = rp.data.ProducerName;
                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("ProducerName"));
                    }
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                cost = rp.data.Cost;
                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("Cost"));
                    }                
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = rp.data.Description;
                    PropertyChangedEventHandler handler = PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("Description"));
                    }
                
            }
        }
        public ProductDetailPageManager productdetailmanager { get; set; }
        public ObservableCollection<ProductImagesList> ProductDetails;
        public ObservableCollection<ProductImagesList> productdetails
        {
            get
            {
                return ProductDetails;
            }
            set
            {
                ProductDetails = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("productdetails"));
            }
        }
        public ProductDetailPageViewModel()
        {
            productdetailmanager = new ProductDetailPageManager();
            GetProductDetails();
        }
        private async void GetProductDetails()
        {
            await productdetailmanager.ProductDetailPageTaskAsync(this);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}