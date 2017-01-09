using NeoStore.CustomView;
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
        int tempId;
        public DetailHomepage()
        {  
            InitializeComponent();
            MessagingCenter.Subscribe<HomepageManager, DetailHomepageModelView>(this, "Child Data", (sender, detail) => {
                BindingContext = detail;
                foreach (var product in detail.ProductCategory)
                {
                    var image = new Image { Source = product.IconImage };
                    image.HorizontalOptions = LayoutOptions.StartAndExpand;
                    CarouselSource.Children.Add(image);
                }

                var grid = new Grid();
               
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                int addCount = 0;    
                    int count = detail.ProductCategory.Count;
                    for (int row = 0; row < count/2; row++)
                    {
                        for (int column = 0; column <= 1; column++)
                        {
                        var name = new CustomGridView { Name = detail.ProductCategory.AsEnumerable().ElementAt(addCount).Name,
                                                        Image= detail.ProductCategory.AsEnumerable().ElementAt(addCount).IconImage,                                                        
                                                        HeightRequest=180,
                                                      };
                        
                        grid.ColumnSpacing = 10;
                        grid.RowSpacing = 10;
                        
                        grid.VerticalOptions = LayoutOptions.FillAndExpand;
                        
                        

                        grid.Children.Add(name, row, column);
                        addCount++;
                        det.Children.Add(grid);

                        var tgr = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
                        tgr.Tapped += OnTapGestureRecognizerTapped;
                        name.GestureRecognizers.Add(tgr);

                    }
                    if (addCount > 3)
                        break;
                    }
            });
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var selectedPage = new ProductListPage();
            Navigation.PushAsync(selectedPage);
        }
    }
}

