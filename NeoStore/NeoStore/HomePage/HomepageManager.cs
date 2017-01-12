using NeoStore.HomePage;
using NeoStore.Loginpage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImageCircle;

namespace NeoStore.HomePage
{
    public class HomepageManager
    {   
        IRestServices restservice;
        public HomepageManager()
        {
            restservice = new HomepageRestServices();
        }

        public async Task ProductDetailAsync()
        {   
            var items = await restservice.ItemDeatils();
            if(items!=null)
            {
                MasterPageViewModel mstr=new MasterPageViewModel();
                DetailHomepageModelView detail = new DetailHomepageModelView();

                mstr.ProductList= new System.Collections.ObjectModel.ObservableCollection<MasterList>();
                detail.ProductCategory = new System.Collections.ObjectModel.ObservableCollection<ProductCategoriesResponse>();

                if (items.data.user_data.ProfilePic == null)
                    mstr.profile_pic = "image.jpg";
                else
                    mstr.profile_pic= items.data.user_data.ProfilePic; 

                mstr.last_name= items.data.user_data.LastName;
                mstr.first_name= items.data.user_data.FirstName; 
                mstr.email= items.data.user_data.Email;

                var abc = items.data;
                var xyz = abc.product_categories;
                var masterProductStatic = new MasterList();
                masterProductStatic.id = 0;
                masterProductStatic.name = "My Cart";
                mstr.ProductList.Add(masterProductStatic);

                var masterProductStatic5 = new MasterList();
                masterProductStatic5.id = 0;
                masterProductStatic5.name = "Homepage";
                mstr.ProductList.Add(masterProductStatic5);


                foreach (var products in abc.product_categories)
                {
                    var masterProduct = new MasterList();
                    masterProduct.id = products.id;
                    masterProduct.name = products.Name;
                    mstr.ProductList.Add(masterProduct);
                }
                
                var masterProductStatic1 = new MasterList();
                masterProductStatic1.id = 0;
                masterProductStatic1.name = "My Account";
                mstr.ProductList.Add(masterProductStatic1);

                var masterProductStatic2 = new MasterList();
                masterProductStatic2.id = 0;
                masterProductStatic2.name = "Store Locator";
                mstr.ProductList.Add(masterProductStatic2);

                var masterProductStatic3 = new MasterList();
                masterProductStatic3.id = 0;
                masterProductStatic3.name = "My Orders";
                mstr.ProductList.Add(masterProductStatic3);

                var masterProductStatic4 = new MasterList();
                masterProductStatic4.id = 0;
                masterProductStatic4.name = "Logout";
                mstr.ProductList.Add(masterProductStatic4);

                
                foreach (var products in abc.product_categories)
                {
                    detail.ProductCategory.Add(products);
                }
               
                MessagingCenter.Send<HomepageManager, DetailHomepageModelView>(this,"Child Data",detail);
                MessagingCenter.Send<HomepageManager,MasterPageViewModel>(this, "Data Available", mstr);
                MessagingCenter.Subscribe<Homepage>(this, "Child Data1", (sender) => {
                    MessagingCenter.Send<HomepageManager, DetailHomepageModelView>(this, "Child Data", detail);
                });
            }
           
        }

        
                
    }
}
