using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace NeoStore.Products
{
    class ProductDetailPageViewModel: INotifyPropertyChanged
    {
        //public static ProductDetailPageResponse rp { get; set; }
        private string productname;
        private string producername;
        private int cost;
        public string description;
        public string ProductName
        {
            get { return productname; }
            set
            {
                productname = value; 
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
                producername = value;
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
                cost = value;
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
                description = value;
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
        public async void GetProductDetails()
        {
            await productdetailmanager.ProductDetailPageTaskAsync(this);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}