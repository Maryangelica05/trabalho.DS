using System;
using Microsoft.Maui.Controls;

namespace trabalho.DS
{
    public partial class Lupa : ContentPage
    {
        public Lupa()
        {
            InitializeComponent();
        }

        private void OnContinuarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão continuar
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
           Application.Current.MainPage = new Login();
        }

        private void OnProximoClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de avançar
             Application.Current.MainPage = new Menu();
        }
    }
}