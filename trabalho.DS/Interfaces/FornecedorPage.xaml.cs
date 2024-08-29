using Microsoft.Maui.Controls;

namespace trabalho.DS
{
 public partial class FornecedorPage : ContentPage
     {
        public FornecedorPage()
        {
            InitializeComponent();
        }
        private void Oncadastrofornecedor(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new CadastrofornecedorPage();
        }

        private void Ongerenciamentofornecedor(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new GerenciamentofornecedorPage();
        }
         private void OnVoltarClicked(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new Menu();
        }
        }
}
  