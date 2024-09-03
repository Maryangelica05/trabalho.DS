using Microsoft.Maui.Controls;
using System;

namespace trabalho.DS
{
    public partial class Estoque : ContentPage
    {
        public Estoque()
        {
            InitializeComponent();
            ExcluirCommand = new Command(OnExcluirCommandExecuted);
        }

        public Command ExcluirCommand { get; }

        private void OnExcluirCommandExecuted()
        {
            // Exibir o Frame de confirmação
            ConfirmacaoFrame.IsVisible = true;
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar a exclusão do material
            DisplayAlert("Confirmado", "Material excluído", "OK");

            // Ocultar o Frame de confirmação
            ConfirmacaoFrame.IsVisible = false;
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Ocultar o Frame de confirmação sem excluir o material
            ConfirmacaoFrame.IsVisible = false;
        }
       private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Menu();
        }
  
    }
}
