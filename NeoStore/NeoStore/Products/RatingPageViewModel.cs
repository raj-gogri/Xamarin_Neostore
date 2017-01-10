using NeoStore.CustomView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeoStore.Products
{
    public class RatingPageViewModel
    {
        public static RatingPageManger ratingpagemanager { get; set; }
        int rate;
        public static int ratingpageviewmodelrating;
        public StarRatingContentView rating;
        public ICommand OnRateClicked { get; set; }
        public RatingPageViewModel()
        {
            ratingpagemanager = new RatingPageManger(new RatingPageRestService());
            OnRateClicked = new Command(
                ()=>
                {
                    ratingpagemanager.RatingTaskAsync(this);
                });
        }
        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = rating.Rating;
                ratingpageviewmodelrating = rate;
            }
        }
    }
}
