using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeoStore.Products
{
    public class RatingPageManger
    {
        IRatingPage restservice;
        public RatingPageManger(IRatingPage service)
        {
            restservice = service;
        }
        public async Task RatingTaskAsync(RatingPageViewModel ratingPageViewModel)
        {
            var items = await restservice.RatingPageTodoAsync(ratingPageViewModel);
            if (items != null)
            {
                MessagingCenter.Send<RatingPageManger>(this, "Rating");
            }
        }
    }
}