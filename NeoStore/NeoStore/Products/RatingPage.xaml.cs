using NeoStore.CustomView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace NeoStore.Products
{
    public partial class RatingPage : ContentPage
    {
        public RatingPage()
        {
            InitializeComponent();
            var star = new StarRatingContentView { OutOffRated = 10, Rating = 3 };
            DetailsRating.Children.Add(star);
        }
    }
}
