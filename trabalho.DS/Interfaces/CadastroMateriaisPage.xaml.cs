using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.DS
{
    public partial class CadastroMateriaisPage : ContentPage
    {
        Controles.MateriaisControle  materiaisControle = new Controles.MateriaisControle();
        Controles.MateriaisControle materiaislControle = new Controles.MateriaisControle();
        public Materiais materiais { get; set; }
        public CadastroMateriaisPage()
        {
            InitializeComponent();
            pickerMaterial.ItemsSource = materiaisControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (materiais != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = materiais.Id.ToString();
                NomeEntry.Text      = materiais.Nome;
                NomefornecedorEntry.Text = materiais.Nomefornecedor;
               AtivoEntry.Text = materiais.Ativo;
                pickerMaterial.SelectedItem = produto.Material;
            }
        }



        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomeEntry.Text) &&
                !string.IsNullOrWhiteSpace(NomeFornecedorEntry.Text) &&
                !string.IsNullOrWhiteSpace(AtivoEntry.Text) &&
            {
                ErrorFrame.IsVisible = true;

                var p = new Material();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    p.Id = int.Parse(IdLabel.Text);
                else

                    p.Id = 0;
                p.nome = NomeEntry.Text;
                p.estoque = NomefornecedorEntry.Text;
                p.Material = pickerMaterial.SelectedItem as Material;
                produtoControle.CriarOuAtualizar(p);

                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new MateriaisPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (produto == null || produto.Id < 1)
                await DisplayAlert("Erro", "Nenhum produto para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse produto?", "Excluir Produto", "cancelar"))
            {
                produtoControle.Apagar(produto.Id);
                Application.Current.MainPage = new EditarProdutosPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}