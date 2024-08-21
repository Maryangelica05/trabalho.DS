

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

           protected override void OnAppearing()
  {
    base.OnAppearing();

    if (cliente != null)
    {
             IdLabel.Text        = cliente.Id.ToString();
             NomeEntry.Text      = cliente.Nome;
             TelefoneEntry.Text  = fornecedor.Telefone;
         
    }
  }


        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Menu();
        }
    }
}