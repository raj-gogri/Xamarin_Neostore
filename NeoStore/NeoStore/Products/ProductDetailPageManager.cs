using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Products
{
     class ProductDetailPageManager
    {
        public static ProductDetailsPageResponseData rp;
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
                rp = items.data;
                int rating = Convert.ToInt32(items.data.Rating);
                productDetailPageViewModel.productdetails = new System.Collections.ObjectModel.ObservableCollection<ProductImagesList>();
                productDetailPageViewModel.productdetails.Clear();
                MessagingCenter.Send<ProductDetailPageManager>(this, "ClearList");
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