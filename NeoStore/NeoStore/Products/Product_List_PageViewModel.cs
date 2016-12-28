using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NeoStore.Products
{
    class Product_List_PageViewModel:INotifyPropertyChanged 
    {
         private ObservableCollection<Product_List_PageResponse> productList;

        public event PropertyChangedEventHandler PropertyChanged;

        public static Product_List_PageResponse product_list_pageresponse { get; set; }
        public static Product_List_PageManager Product_List_pageManager { get; set;}
        public Product_List_PageViewModel()
        {
            Product_List_pageManager = new Product_List_PageManager(new Product_List_PageRestService());
            Product_List_pageManager.Product_List_PageTaskAsync(this);
        }
        public ObservableCollection<Product_List_PageResponse> ProductList
        {
            get
            {
                return productList;
            }

            set
            {
                productList = value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("ProductList"));
                }
            }
        }
        
    }
}