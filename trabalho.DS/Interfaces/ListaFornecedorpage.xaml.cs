using Microsoft.Maui.Controls;
using System;
using Modelos;


namespace trabalho.DS;
public partial class ListaFornecedorPage : ContentPage
{
  Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

  public ListaFornecedorPage()
	{
		InitializeComponent();
    // Buscamos no banco de dados, via Controle, a lista de todos os Fornecdores cadastrados
    ListaFornecedor.ItemsSource = fornecedorControle.LerTodos();
	}

  // Esse método será chamado toda vez que o usuário selecionar um cliente na lista
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroClientePage,
    // que é a página onde os dados do cliente podem ser criados/editados
    var page = new GerenciamentofornecedorPage();
    // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
    // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
    // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
    // com o cliente que foi clicado aqui.
    page.fornecedor = e.SelectedItem as Fornecedor;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo cliente, não é necessário setar o atributo "cliente" no CadastroClientePage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new CadastrofornecedorPage();
  }
  private async void OnContinuarClicked (object sender, EventArgs e)
        {
            // Lógica para o botão de cadastro
            Application.Current.MainPage = new Menu();
        }
}