using Xamarin.Forms;
using NeoStore.CustomView;
using NeoStore.Droid;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(GothamLabelText), typeof(GothamFontRenderer))]
namespace NeoStore.Droid
{
    class GothamFontRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var label = (TextView)Control;
            var text = label.Text;
            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "gotham-book.ttf");
            label.Typeface = font;
        }


    }
}