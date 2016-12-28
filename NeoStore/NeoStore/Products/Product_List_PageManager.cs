using System;
using System.Threading.Tasks;

namespace NeoStore.Products
{
     class Product_List_PageManager
    {
        IProduct_List_PageRestService restService;

        public Product_List_PageManager(IProduct_List_PageRestService service)
        {
            restService = service;
        }
        public async Task Product_List_PageTaskAsync(Product_List_PageViewModel product_List_PageViewModel)
        {
            var items = await restService.Product_List_PageTodoAsync(product_List_PageViewModel);
            Product_List_PageViewModel.product_list_pageresponse = items;
        }
    }
}