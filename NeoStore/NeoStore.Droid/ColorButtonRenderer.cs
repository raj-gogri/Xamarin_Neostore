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
using NeoStore.CustomView;
using NeoStore.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly:ExportRenderer(typeof(ColorButton), typeof(ColorButtonRenderer))]

namespace NeoStore.Droid
{
    class ColorButtonRenderer:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome-webfont.ttf");
            Control.Typeface = font;
            Control.SetBackgroundResource(Resource.Drawable.Color_Btn);
        }
    }
}