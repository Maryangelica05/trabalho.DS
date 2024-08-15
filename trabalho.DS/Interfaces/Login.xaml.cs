using Microsoft.Maui.Controls;
using System;

namespace trabalho.DS
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Acessar diretamente os controles UI como membros da classe
            string cpfCnpjText = CpfCnpj.Text; // `CpfCnpj` é um Entry definido no XAML
            string senhaText = Senha.Text;     // `Senha` é um Entry definido no XAML

            // Implementar lógica de autenticação
            if (string.IsNullOrWhiteSpace(cpfCnpjText) || string.IsNullOrWhiteSpace(senhaText))
            {
                DisplayAlert("Erro", "Preencha todos os campos.", "OK");
                return;
            }

            // Exemplo de lógica de autenticação (substitua com a sua própria lógica)
            // bool isAuthenticated = Authenticate(cpfCnpjText, senhaText);
            // if (isAuthenticated)
            // {
            //     // Navegar para a próxima página ou mostrar uma mensagem de sucesso
            // }
            // else
            // {
            //     DisplayAlert("Erro", "CPF/CNPJ ou senha inválidos.", "OK");
            // }
        }

        private async void OnNoCadastroButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de cadastro
            await DisplayAlert("Cadastro", "Ainda não foi implementado.", "OK");
        }


        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
              Application.Current.MainPage = new Login();
            if (Navigation.NavigationStack.Count > 1)
            {
                await Navigation.PopAsync();
                
            }
            else
            {
                DisplayAlert("Aviso", "Não há páginas anteriores.", "OK");
            }
        }

        private void OnProximoClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de avançar
            DisplayAlert("Navegação", "Ainda não foi implementado.", "OK");
        }
    }
}






