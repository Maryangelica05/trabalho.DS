using Microsoft.Maui.Controls;

namespace trabalho.DS
{
 public partial class Fornecedor : ContentPage
     {
        public Fornecedor()
        {
            InitializeComponent();
        }
        private void Oncadastrofornecedor(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new Cadastrofornecedor();
        }

        private void Ongerenciamentofornecedor(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Gerenciamentofornecedor();
        }
         private void OnVoltarClicked(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new Menu();
        }
        }
}
  