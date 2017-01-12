using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.CustomView
{
    public partial class CustomGridView : ContentView
    {
        public string Image
        {
            set
            {
               IconImageCat.Source=value ;
            }
        }

        public string Name
        {
            set
            {
                ItemNameCat.Text = value;
            }
        }
        public CustomGridView()
        {
            InitializeComponent();
        }
    }
}
