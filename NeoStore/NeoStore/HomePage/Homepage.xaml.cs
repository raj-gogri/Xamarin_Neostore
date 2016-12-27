using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.HomePage
{
    public partial class Homepage : MasterDetailPage
    {
        public Homepage()
        {
            InitializeComponent();
            BindingContext = new HomepageModelView();
        }
    }
}
