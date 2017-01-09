using Xamarin.Forms;
using NeoStore.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using NeoStore.CustomView;

using Android.Graphics;


[assembly: ExportRenderer(typeof(RoundedButton), typeof(CustomeButtonRenderer))]
namespace NeoStore.Droid
{
    public class CustomeButtonRenderer:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome-webfont.ttf");
            Control.Typeface = font;
            Control.SetBackgroundResource(Resource.Drawable.rounded_corner_shape);
        }

    }
}