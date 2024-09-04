using Microsoft.Maui.Controls;

namespace trabalho.DS
{
 public partial class MateriaisPage : ContentPage
     {
        public MateriaisPage()
        {
            InitializeComponent();
        }
        private void Oncadastromaterial(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new CadastroMateriaisPage();
        }

        private void Ongerenciamentomaterial(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new GerenciamentomateriaisPage();
        }
         private void OnVoltarClicked(object sender, EventArgs e)
        
        {
            // Lógica para o botão continuar
            Application.Current.MainPage = new Menu();
        }
        }
}
  
