﻿using NeoStore.HomePage;
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
       HomepageManager homepageManager { get; set; }
        public Homepage()
        {
            
            
            InitializeComponent();
           
            Detail = new NavigationPage(new DetailHomepage());

            homepageManager = new HomepageManager();
            MessagingCenter.Subscribe<MasterPage,Page>(this, "Child Select", (sender,Child) => {
                IsPresented = false;
                Detail = new NavigationPage(Child);
               
            });

            MessagingCenter.Subscribe<MasterPage>(this, "homepage Select", (sender) => {
                IsPresented = false;
                //DetailHomepageModelView det = new DetailHomepageModelView();
               
                Detail = new NavigationPage(new DetailHomepage());
                MessagingCenter.Send<Homepage>(this, "Child Data1");

                
            });
            GetProductList();
            
        }
        public async void GetProductList()
        {
            await homepageManager.ProductDetailAsync();
        }

    }
}
