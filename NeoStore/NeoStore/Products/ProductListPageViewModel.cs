using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NeoStore.Products
{
    class ProductListPageViewModel : INotifyPropertyChanged
    {
        public ProductListPageManager ProductListpageManager { get; set;}
        public ObservableCollection<ProductListPageResponseData> ProductList;
        public ObservableCollection<ProductListPageResponseData> productList
        {
            get
            {
                return ProductList;
            }
            set
            {
                ProductList = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs("productList"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ProductListPageViewModel()
        {
            ProductListpageManager = new ProductListPageManager();
            GetProductList();
        }
        private async void GetProductList()
        {
            await ProductListpageManager.ProductListPageTaskAsync(this);
        }        
    }
}