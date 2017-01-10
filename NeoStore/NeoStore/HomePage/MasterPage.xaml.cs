using NeoStore.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle;

using Xamarin.Forms;

namespace NeoStore.HomePage
{
    public partial class MasterPage : ContentPage
    {
        public static int tempId;
        public MasterPage()
        {
            
            InitializeComponent();
            BackgroundColor = Color.Black;
           
            MessagingCenter.Subscribe<HomepageManager, MasterPageViewModel>(this, "Data Available", (sender, mstr) => {
                BindingContext = mstr;
                
            });
        }
        void ProductSelected(object sender, SelectedItemChangedEventArgs args)
        {
           DetailHomepage det =new DetailHomepage();
            var selected = (MasterList)args.SelectedItem;
            tempId = selected.id;
            var selectedPage = new ProductListPage();
            if (selected.name == "Homepage")
            {
                MessagingCenter.Send<MasterPage>(this, "homepage Select");
            }
            else
            {
                // App.Current.MainPage = (new Homepage());
                MessagingCenter.Send<MasterPage,Page>(this, "Child Select",selectedPage);
            }
        }


    }
}
