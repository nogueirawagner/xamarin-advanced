using Xamarin.Forms;


#if __ANDROID__
using Android.Widget;
using Android.Support.Design.Widget;
using Xamarin.Forms.Platform.Android;
#endif

namespace SharedAdv
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

#if __ANDROID__

      var lblDroid = new TextView(Forms.Context)
      {
        Text = "Android nativo"
      };
      container.Children.Add(lblDroid);

      var fBtn = new FloatingActionButton(Forms.Context);
      fBtn.SetImageResource(Droid.Resource.Drawable.ic_media_play_light);

      ctAbs.Children.Add(fBtn);

      fBtn.Click += delegate
      {
        DisplayAlert("Alerta", "O botao foi clicado", "Cancela");
      };




#endif

    }
  }
}
