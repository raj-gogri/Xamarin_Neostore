using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.HomePage
{
    class DetailHomepageModelView: INotifyPropertyChanged
    {
        public ObservableCollection<ProductCategoriesResponse> productCategory;
        public event PropertyChangedEventHandler PropertyChanged;
        public HomepageManager homepageManager { get; set; }
        public ICommand OnMyCartSelected { get; set; }
        public ObservableCollection<ProductCategoriesResponse> ProductCategory
        {
            get
            {
                return productCategory;
            }
            set
            {
                productCategory=value;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                    handler(this,new PropertyChangedEventArgs("ProductCategory"));
            }
        }
        
        public DetailHomepageModelView()
        {
            homepageManager = new HomepageManager();
            //GetProductList();
            //OnMyCartSelected = new Command(
            //     () =>
            //     {
            //         MessagingCenter.Send<DetailHomepageModelView>(this, "NavigateCart");

            //     });
        }

      //  public async void GetProductList()
        //{
     //       await homepageManager.ProductDetailAsync();
        //}
    }
}