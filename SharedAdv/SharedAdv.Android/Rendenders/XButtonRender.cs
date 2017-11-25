using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(SharedAdv.Customs.ButtonCustom), typeof(SharedAdv.Droid.Rendenders.XButtonRender))]
namespace SharedAdv.Droid.Rendenders
{
  public class XButtonRender : ButtonRenderer
  {
    protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
    {
      base.OnElementChanged(e);
      if(Control != null)
      {
        Control.SetBackgroundResource(Resource.Drawable.button_rounded);

      }
    }
  }
}