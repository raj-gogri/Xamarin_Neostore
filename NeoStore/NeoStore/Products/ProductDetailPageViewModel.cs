using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NeoStore.Products
{
    class ProductDetailPageViewModel: INotifyPropertyChanged
    {
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