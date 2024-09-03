using Microsoft.Maui.Controls;
using System;

namespace trabalho.DS
{
    public partial class Estoque : ContentPage
    {
        public Estoque()
        {
            InitializeComponent();
           
        }

        public Command ExcluirCommand { get; }

     

      
       private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
              Application.Current.MainPage = new Menu();
        }
  
    }
}
