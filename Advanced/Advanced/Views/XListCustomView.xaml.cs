using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Advanced.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XListCustomView : ContentPage
	{
		public XListCustomView ()
		{
			InitializeComponent ();
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
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
        },
        new Categoria("Beleza", "BLZ", "Tudo beleza de boa?")
        {
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
        },
        new Categoria("Serviços", "SVC", "Servicos gerais")
        {
          new Pessoa { Nome = "Jose" },
          new Pessoa { Nome = "Maria" },
          new Pessoa { Nome = "Pedro" },
          new Pessoa { Nome = "Joao" },
          new Pessoa { Nome = "Davi" },
          new Pessoa { Nome = "Elias" },
          new Pessoa { Nome = "Salomao"},
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