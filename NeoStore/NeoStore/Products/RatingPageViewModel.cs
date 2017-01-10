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
    public class RatingPageViewModel:INotifyPropertyChanged
    {
        public static RatingPageManger ratingpagemanager { get; set; }
        int rate;
        string productname;
        string productimage;
        public static int ratingpageviewmodelrating;
        public StarRatingContentView rating;

        public event PropertyChangedEventHandler PropertyChanged;

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
                rate = value;
                ratingpageviewmodelrating = rate;
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("Rate"));
                }
            }
        }
        public string ProductName
        {
            get
            {
                return productname;
            }
            set
            {
                productname = value;
            }
        }

        public string ProductImg
        {
            get
            {
                return productimage;
            }
            set
            {
                productimage = value;
            }
        }
    }
}
