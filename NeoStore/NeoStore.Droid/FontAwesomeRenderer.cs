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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using NeoStore.Droid;
using NeoStore.CustomView;
using Android.Graphics;

[assembly: ExportRenderer(typeof(AwesomeLabel), typeof(FontAwesomeRenderer))]
namespace NeoStore.Droid
{
    public class FontAwesomeRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var label = (TextView)Control;
            var text = label.Text;

            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome-webfont.ttf");

            label.Typeface = font;
        }
    }
}