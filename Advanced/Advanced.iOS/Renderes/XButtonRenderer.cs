using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace Advanced.iOS.Renderes
{
  public class XButtonRenderer : ButtonRenderer
  {
    protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
    {
      base.OnElementChanged(e);
      if(Control != null)
      {
        Control.Layer.CornerRadius = 10;
        Control.ClipsToBounds = true;
      }
    }
  }
}
