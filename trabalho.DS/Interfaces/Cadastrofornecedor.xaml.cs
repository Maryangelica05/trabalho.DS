

namespace trabalho.DS
{
    public partial class Cadastrofornecedor : ContentPage
    {
        public Cadastrofornecedor()
        {
            InitializeComponent();
        }
          public Fornecedor fornecedor { get; set; }
          Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

       void VoltarClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new ListaFornecedorpage();
  }



           protected override void OnAppearing()
  {
        base.OnAppearing();

    if (fornecedor != null)
    {
             IdLabel.Text        = fornecedor.Id.ToString();
             NomefornecedorEntry.Text  = fornecedor.Nomefornecedor;
             TelefoneEntry.Text  = fornecedor.Telefone;
         
    }
  }
private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (fornecedor == null || fornecedor.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      fornecedorControle.Apagar(fornecedor.Id);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new ListaFornecedorpage(); 
    }
  }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
           if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
    {
      // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
      var fornecedor = new Modelos.Fornecedor();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        fornecedor.Id      = int.Parse(IdLabel.Text);
      else
        fornecedor.Id      = 0;
      fornecedor. Nomefornecedor     = NomefornecedorEntry.Text;
      fornecedor.Telefone = TelefoneEntry.Text;
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Menu();
        }
        
    }
}
}