using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.HomePage
{
    public partial class DetailHomepage : ContentPage
    {
        public DetailHomepage()
        {
            BindingContext = new DetailHomepageModelView();
            InitializeComponent();
        }
    }
}
