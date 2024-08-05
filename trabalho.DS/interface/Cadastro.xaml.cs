

using Microsoft.Maui.Controls;
using System;

namespace trabalho.DS
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private async void OnFinalizarCadastroClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string cpfCnpj = CpfCnpjEntry.Text;
            string senha = SenhaEntry.Text;
            string confirmaSenha = ConfirmaSenhaEntry.Text;

            if (senha != confirmaSenha)
            {
                await DisplayAlert("Erro", "As senhas não coincidem.", "OK");
                return;
            }

            // Aqui você pode adicionar a lógica para salvar os dados do usuário
            // e retornar para a tela de login

            await DisplayAlert("Sucesso", "Cadastro realizado com sucesso!", "OK");
            await Navigation.PopAsync(); // Volta para a tela anterior (login)
        }
    }
}

