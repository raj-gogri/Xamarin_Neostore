using NeoStore.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle;

using Xamarin.Forms;
using NeoStore.Loginpage;

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
            if(selected.id!=0)
                tempId = selected.id;           
            var selectedPage = new ProductListPage { Title = selected.name };
            if (selected.name == "Homepage")
            {
                MessagingCenter.Send<MasterPage>(this, "homepage Select");
            }
            else if (selected.name == "Logout")
            {
                App.Database.DeleteUserDetails(App.UserLoggedInDetails);
                App.Current.MainPage = new LoginPage();
            }
            else
            {
                MessagingCenter.Send<MasterPage,Page>(this, "Child Select",selectedPage);
            }
        }


    }
}
