using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SharedAdv.CustomRenderes
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XCustomRenderView : ContentPage
  {
    public XCustomRenderView()
    {
      InitializeComponent();

      var botao = new Button();
      botao.Text = "Eu sou diferente";
      botao.TextColor = Color.Coral;

      Container.Children.Add(botao);
    }
  }
}