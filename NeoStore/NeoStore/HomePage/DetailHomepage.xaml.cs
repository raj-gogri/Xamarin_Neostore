﻿using NeoStore.CustomView;
using NeoStore.Products;
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
       // int tempId;
        public DetailHomepage()
        {
            //DetailHomepageModelView det;
            InitializeComponent();

            MessagingCenter.Subscribe<HomepageManager, DetailHomepageModelView>(this, "Child Data", (sender, detail) => {
                BindingContext = detail;
                //det = detail;
                foreach (var product in detail.ProductCategory)
                {
                    var image = new Image { Source = product.IconImage };
                    image.HorizontalOptions = LayoutOptions.StartAndExpand;
                    CarouselSource.Children.Add(image);
                }
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                int addCount = 0;    
                int count = detail.ProductCategory.Count;
                int ccount =Convert.ToInt32(count / 2);
                    for (int row = 0; row < ccount; row++)
                    {
                        for (int column = 0; column <= 1; column++)
                        {
                            var name = new CustomGridView { Name = detail.ProductCategory.AsEnumerable().ElementAt(addCount).Name,
                            Image = detail.ProductCategory.AsEnumerable().ElementAt(addCount).IconImage,
                            BackgroundColor = Color.Red,
                            HeightRequest=210,
                                                      };
                      
                        grid.Children.Add(name, row, column);
                        addCount++;

                        var tgr = new TapGestureRecognizer {
                         CommandParameter= detail.ProductCategory.AsEnumerable().ElementAt(addCount-1).id,
                            
                            Command =new Command<int>(
                            (parameter) =>
                            {   
                                MasterPage.tempId = parameter;
                                var selectedPage = new ProductListPage { Title= detail.ProductCategory.AsEnumerable().ElementAt(parameter-1).Name};
                                MessagingCenter.Send<DetailHomepage, Page>(this, "Child Select detail", selectedPage);
                            }
                            )};
                        
                        //tgr.Tapped += OnTapGestureRecognizerTapped;
                        name.GestureRecognizers.Add(tgr);

                    }
                    if (addCount > (count-1))
                        break;
                    }
            });
        }

       
    }
}

