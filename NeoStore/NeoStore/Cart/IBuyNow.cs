using NeoStore.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.Cart
{
    public interface IBuyNow
    {
        Task<BuyNowResponse> BuyNowTodoAsync(BuyNowViewModel item);
    }
}
