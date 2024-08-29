using Microsoft.Maui.Controls;

namespace trabalho.DS
{

    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Lupa();
        }
        private void OnProximoClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Login();
        }
        private void OnFornecedorClicked(object sender, EventArgs e)
        {
         Application.Current.MainPage = new FornecedorPage();
        }

        private void OnMateriaisClicked(object sender, EventArgs e)
        {
         Application.Current.MainPage = new Materiais();
        }

        private void OnEstoqueClicked(object sender, EventArgs e)
        {
         Application.Current.MainPage = new Estoque();
        }
       
          private void OnGastoClicked(object sender, EventArgs e)
        {
         Application.Current.MainPage = new Financeiro();
        }
    }
}