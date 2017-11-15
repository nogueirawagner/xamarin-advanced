using Advanced.Lib.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Advanced.Views.XDataSelectorView;

namespace Advanced.Lib.SelectorTemplates
{
  public class SelectorTemplate : DataTemplateSelector
  {
    DataTemplate Obrigatorio;
    DataTemplate NaoObrigatorio;

    public SelectorTemplate()
    {
      Obrigatorio = new DataTemplate(typeof(XPessoaObrigatorioView));
      NaoObrigatorio = new DataTemplate(typeof(XPessoaNaoObrigatorioView));
    }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
      var pessoa = (Pessoa)item;
      if (pessoa.Obrigatorio)
        return Obrigatorio;
      else
        return NaoObrigatorio;

    }
  }
}
