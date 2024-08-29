
using Microsoft.Maui.Controls;
using Modelos;
namespace trabalho.DS
{
  public partial class GerenciamentofornecedorPage : ContentPage
  {
    public Fornecedor fornecedor { get; set; }
    Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
    public GerenciamentofornecedorPage()
    {
      InitializeComponent();
      ListaFornecedores.ItemsSource = fornecedorControle.LerTodos();
    }
    void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
    {
      // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroClientePage,
      // que é a página onde os dados do cliente podem ser criados/editados
      var page = new CadastrofornecedorPage();
      // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
      // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
      // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
      // com o cliente que foi clicado aqui.
      page.fornecedor = e.SelectedItem as Fornecedor;
      // Troca-se a página principal para a página que acabamos de criar
      Application.Current.MainPage = page;
    }

    void NovoFornecedorClicked(object sender, EventArgs e)
    {
      // Quando a idéia é CRIAR um novo cliente, não é necessário setar o atributo "cliente" no CadastroClientePage,
      // sendo assim, apenas criamos a nova página
      Application.Current.MainPage = new CadastrofornecedorPage();
    }
  }

}







