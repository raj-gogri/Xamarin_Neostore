using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Products
{
     public class ProductListPageManager
    {
        IProductListPageRestService restService;

        public ProductListPageManager()
        {
            restService = new ProductListPageRestService();
        }
        public async Task ProductListPageTaskAsync(ProductListPageViewModel productListPageViewModel)
        {
            var items = await restService.ProductListPageTodoAsync(productListPageViewModel);
            if (items != null)
            {
                productListPageViewModel.productList = new System.Collections.ObjectModel.ObservableCollection<ProductListPageResponseData>();
               
                foreach (var Product in items.data)
                {
                    productListPageViewModel.productList.Add(Product);
                    var Rating = Product.Rating;
                    MessagingCenter.Send<ProductListPageManager, float>(this,"StarRating", Rating);
                }
            }
        }
    }
}