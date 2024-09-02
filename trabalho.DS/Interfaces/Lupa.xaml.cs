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
            Application.Current.MainPage = new Menu();
        }

   }
}