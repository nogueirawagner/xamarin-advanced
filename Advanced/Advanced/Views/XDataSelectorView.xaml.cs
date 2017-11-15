using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Advanced.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XDataSelectorView : ContentPage
  {
    public XDataSelectorView()
    {
      InitializeComponent();
      ListaFuncionarios.ItemsSource = GetPessoas();
    }

    public class Pessoa
    {
      public string Nome { get; set; }
      public int Rank { get; set; }
      public bool Obrigatorio { get; set; }
    }

    public class Categoria : List<Pessoa>
    {
      public string Titulo { get; set; }
      public string TituloAbreviado { get; set; }
      public string Descricao { get; set; }

      public Categoria(string pTitulo, string pTituloAbreviado, string pDescricao)
      {
        Titulo = pTitulo;
        TituloAbreviado = pTituloAbreviado;
        Descricao = pDescricao;
      }
    }

    private List<Categoria> GetPessoas()
    {
      return new List<Categoria>()
      {

        new Categoria("Estetica", "ESTC", "Apenas produtos de estetica")
        {
          new Pessoa { Nome = "Jose", Obrigatorio = true, Rank = 9 },
          new Pessoa { Nome = "Maria", Obrigatorio = false, Rank = 1 },
          new Pessoa { Nome = "Pedro", Obrigatorio = true, Rank = 5 },
          new Pessoa { Nome = "Joao" , Obrigatorio = true, Rank = 3},
          new Pessoa { Nome = "Davi" , Obrigatorio = false, Rank = 4},
        },
        new Categoria("Beleza", "BLZ", "Tudo beleza de boa?")
        {
          new Pessoa { Nome = "Jose", Obrigatorio = true, Rank = 9 },
          new Pessoa { Nome = "Maria", Obrigatorio = true, Rank = 5 },
          new Pessoa { Nome = "Pedro", Obrigatorio = false, Rank = 3 },
          new Pessoa { Nome = "Joao" , Obrigatorio = true, Rank = 7},
          new Pessoa { Nome = "Davi" , Obrigatorio = false, Rank = 8},
        },
        new Categoria("Serviços", "SVC", "Servicos gerais")
        {
          new Pessoa { Nome = "Jose" , Obrigatorio = true, Rank = 8},
          new Pessoa { Nome = "Maria", Obrigatorio = false, Rank = 5 },
          new Pessoa { Nome = "Pedro", Obrigatorio = false, Rank = 8 },
          new Pessoa { Nome = "Joao" , Obrigatorio = true, Rank =  2},
          new Pessoa { Nome = "Davi" , Obrigatorio = false, Rank = 3},
          new Pessoa { Nome = "Elias", Obrigatorio = false, Rank =1 },
          new Pessoa { Nome = "Salomao", Obrigatorio = true, Rank = 5},
          new Pessoa { Nome = "Jose" , Obrigatorio = false, Rank = 0},
          new Pessoa { Nome = "Maria", Obrigatorio = false, Rank = 3 },
          new Pessoa { Nome = "Pedro", Obrigatorio = false, Rank = 8 },
          new Pessoa { Nome = "Joao" , Obrigatorio = true, Rank = 4},
          new Pessoa { Nome = "Davi" , Obrigatorio = false, Rank = 5},
          new Pessoa { Nome = "Elias", Obrigatorio = false, Rank = 1 },
          new Pessoa { Nome = "Saloma", Obrigatorio = true, Rank = 2}
        }
      };
    }

  }
}