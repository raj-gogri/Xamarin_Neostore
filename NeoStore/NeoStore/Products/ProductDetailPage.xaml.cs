using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.Products
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage()
        {
            InitializeComponent();
            buynow.BackgroundColor  = Color.Red;
            rate.BackgroundColor = Color.Gray;

        }
    }
}
