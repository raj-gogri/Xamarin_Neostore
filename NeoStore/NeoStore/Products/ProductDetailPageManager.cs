using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Products
{
     class ProductDetailPageManager
    {
       
        IProductDetailPageRestService restservice;

        public ProductDetailPageManager()
        {
            restservice=new ProductDetailsPageRestService();
        }
        public async Task ProductDetailPageTaskAsync(ProductDetailPageViewModel productDetailPageViewModel)
        {
            var items = await restservice.ProductDetailsPageTodoAsync(productDetailPageViewModel);
            if (items != null)
            {
                //ProductDetailPageViewModel.rp = items;
                int rating = items.data.Rating;
                productDetailPageViewModel.productdetails = new System.Collections.ObjectModel.ObservableCollection<ProductImagesList>();
                foreach (var Product in items.data.ProductImageslist)
                {
                    productDetailPageViewModel.productdetails.Add(Product);
                    MessagingCenter.Send<ProductDetailPageManager, ProductImagesList>(this, "Images", Product);
                }
                MessagingCenter.Send<ProductDetailPageManager, int>(this, "ProductDetailRating", rating);
            }
        }
    }
}