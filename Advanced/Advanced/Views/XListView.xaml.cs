using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Advanced.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XListView : ContentPage
  {
    public XListView()
    {
      InitializeComponent();
      ListaFuncionarios.ItemsSource = GetPessoas();
    }

    public class Pessoa
    {
      public string Nome { get; set; }
    }

    public class Categoria : List<Pessoa>
    {
      public string Titulo { get; set; }
      public string TituloAbreviado { get; set; }

      public Categoria(string pTitulo, string pTituloAbreviado)
      {
        Titulo = pTitulo;
        TituloAbreviado = pTituloAbreviado;
      }
    }

    private List<Categoria> GetPessoas()
    {
      return new List<Categoria>()
      {

        new Categoria("Estetica", "ESTC")
        {
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
        },
        new Categoria("Beleza", "BLZ")
        {
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
        },
        new Categoria("Serviços", "SVC")
        {
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
          new Pessoa { Nome = "Elias" },
          new Pessoa { Nome = "Salomao"}
        }
      };
    }


  }
}
