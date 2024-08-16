

namespace trabalho.DS
{
    public partial class Cadastrofornecedor : ContentPage
    {
        public Cadastrofornecedor()
        {
            InitializeComponent();
        }
        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Menu();
        }
    }
}