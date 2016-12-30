using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    interface IProductDetailPageRestService
    {
        Task<ProductDetailPageResponse> ProductDetailsPageTodoAsync(ProductDetailPageViewModel item);

    }
}
