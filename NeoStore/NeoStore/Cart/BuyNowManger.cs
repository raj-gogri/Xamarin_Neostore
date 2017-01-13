using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Cart
{
    public class BuyNowManger
    {
        IBuyNow restservices;
        public BuyNowManger(IBuyNow services)
        {
            restservices = services;
        }

        public async Task BuyNowTaskAsync(BuyNowViewModel buynowViewModel)
        {
            var items = await restservices.BuyNowTodoAsync(buynowViewModel);
            if (items != null)
            {
                MessagingCenter.Send<BuyNowManger>(this, "BuyNow");
            }
        }
    }
}