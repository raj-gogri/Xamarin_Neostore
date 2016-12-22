using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using NeoStore.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using NeoStore;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRenderer))]

namespace NeoStore.Droid 
{
    public class RoundedButtonRenderer:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome.ttf");
            Control.Typeface = font;
            Control.SetBackgroundResource(Resource.Drawable.rounded_corner_shape);
        }
        //protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        //{
        //    base.OnElementChanged(e);
        //    var label = (TextView)Control;
        //    var text = label.Text;
        //    var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome.ttf");
        //    label.Typeface = font;
        //}
    }
}