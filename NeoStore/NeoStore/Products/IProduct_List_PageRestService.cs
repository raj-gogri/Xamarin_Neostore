using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Products
{
    interface IProduct_List_PageRestService
    {
        Task<Product_List_PageResponse> Product_List_PageTodoAsync(Product_List_PageViewModel item);
    }
}
