using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NeoStore.CustomView
{
    public partial class StarRatingContentView : ContentView
    {
        public static int x;
        int rating;
        int outoffRated;
        public int OutOffRated
        {
            set
            {
                outoffRated = value;
            }
            get
            {
                return outoffRated;
            }
        }
        public int Rating
        {
            set
            {
                rating = value;
                for (int i = 1; i <= OutOffRated; i++)
                {
                    AwesomeLabel star = null;

                    if (i <= rating)
                    {
                        star = new AwesomeLabel { Text = FontAwesome.FAStar, TextColor = Color.Yellow, FontSize = 40 };
                    }
                    else
                    {
                        star = new AwesomeLabel { Text = FontAwesome.FAStar, TextColor = Color.Gray, FontSize = 40 };
                    }
                    currentRating.Children.Add(star);
                    var startapGestureRecognizer = new TapGestureRecognizer
                    {
                        CommandParameter = i,
                        Command = new Command<int>((parmeter) => {
                            currentRating.Children.Clear();
                            currentRating.Children.Add(new StarRatingContentView { OutOffRated = outoffRated, Rating = parmeter });
                            x = parmeter;
                        })
                    };
                    star.GestureRecognizers.Add(startapGestureRecognizer);
                }
            }
            get
            {
                return rating;
            }
        }
        public StarRatingContentView()
        {
            InitializeComponent();
        }
    }
}
