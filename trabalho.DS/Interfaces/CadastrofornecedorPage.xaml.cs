using Microsoft.Maui.Controls;
using Controles;
using Modelos;

namespace trabalho.DS;

public partial class CadastrofornecedorPage : ContentPage
{
  //--------------------------------------------------------------------------------------------------
  // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
  // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
  // ClienteControle que irá criar/atualizar o Banco de Dados
  public Fornecedor fornecedor { get; set; }
  Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

  //--------------------------------------------------------------------------------------------------

public CadastrofornecedorPage ()
{
  InitializeComponent ();
}

  //--------------------------------------------------------------------------------------------------

  void VoltarClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new ListaFornecedorPage();
  }

  //--------------------------------------------------------------------------------------------------
  // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
  // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
  protected override void OnAppearing()
  {
    base.OnAppearing();

    if (fornecedor != null)
    {
      IdLabel.Text = fornecedor.Id.ToString();
      NomeEntry.Text = fornecedor.Nome;
      TelefoneEntry.Text = fornecedor.Telefone;
      CnpjEntry.Text= fornecedor.Cnpj;
    }
  }

  //--------------------------------------------------------------------------------------------------
  // Método para limpar os dados da Entry
  private async void OnApagarForneecdorClicked(object sender, EventArgs e)
  {
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (fornecedor == null || fornecedor.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      fornecedorControle.Apagar(fornecedor.Id);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new ListaFornecedorPage();
    }
  }

  //--------------------------------------------------------------------------------------------------

  private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
    {
      // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
      var fornecedor = new Modelos.Fornecedor();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        fornecedor.Id = int.Parse(IdLabel.Text);
      else
        fornecedor.Id = 0;
      fornecedor.Nome = NomeEntry.Text;
      fornecedor.Telefone = TelefoneEntry.Text;
      fornecedor.Cnpj=CnpjEntry.Text;

      // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
      fornecedorControle.CriarOuAtualizar(fornecedor);
      // Mostra a mensagem de sucesso
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
  }

  //--------------------------------------------------------------------------------------------------
  // Esse método pode ser escrito de várias maneiras. A idéia é que você valide os dados antes de 
  // preencher o objeto (Modelo). 
  // Perceba que além da retornar false (para indicar erro), também mostra qual o erro
  private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(NomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Sobrenome está vazia
else if (String.IsNullOrEmpty(CnpjEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo CNPJ é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Telefone está vazia
    else if (String.IsNullOrEmpty(TelefoneEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
      return false;
    }
    else
      return true;
  }

  //--------------------------------------------------------------------------------------------------
}
