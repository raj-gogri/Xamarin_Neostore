using Xamarin.Forms;
using NeoStore.Droid;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using NeoStore;
using Android.Graphics.Drawables;
using NeoStore.Behaviours;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(CustomeButtonRenderer))]
namespace NeoStore.Droid
{  
    public class CustomeButtonRenderer:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement!=null)
            {

            }
            else if (e.OldElement != null)
            {

            }

            if (Control != null)
            {
                GradientDrawable gradientDrwable = new GradientDrawable();
                gradientDrwable.SetShape(ShapeType.Rectangle);
                gradientDrwable.SetCornerRadius(20f);
                gradientDrwable.SetColor(Element.BackgroundColor.ToAndroid());

                Control.SetBackgroundDrawable(gradientDrwable);
            }
        }
    }
}