using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.DS
{
    public partial class CadastroMateriaisPage : ContentPage
    {
        public Materiais materiais { get; set; }
        Controles.MateriaisControle materiaisControle = new Controles.MateriaisControle();

        public CadastroMateriaisPage()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaMateriaisPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (materiais != null)
            {
                IdLabel.Text = materiais.Id.ToString();
                NomeMaterialEntry.Text = materiais.Nome;
                NomeFornecedorEntry.Text = materiais.NomeFornecedor;
                AtivoEntry.Text = materiais.Ativo;
            }
        }

        private async void OnApagarMaterialClicked(object sender, EventArgs e)
        {
            // Verifica se estamos editando um material ou criando um material
            if (materiais == null || materiais.Id < 1)
            {
                await DisplayAlert("Erro", "Nenhum material para excluir", "OK");
            }
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse material?", "Excluir Material", "Cancelar"))
            {
                // Apaga do Banco de Dados
                materiaisControle.Apagar(materiais.Id);
                // Volta para a tela de Lista
                Application.Current.MainPage = new ListaMateriaisPage();
            }
        }

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                if (materiais == null)
                    materiais = new Modelos.Materiais(); // Corrigir para usar a classe correta

                materiais.Id = !String.IsNullOrEmpty(IdLabel.Text) ? int.Parse(IdLabel.Text) : 0;
                materiais.Nome = NomeMaterialEntry.Text;
                materiais.NomeFornecedor = NomeFornecedorEntry.Text;
                materiais.Ativo = AtivoEntry.Text;

                materiaisControle.CriarOuAtualizar(materiais);
                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
                Application.Current.MainPage = new ListaMateriaisPage();
            }
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(NomeMaterialEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome do Fornecedor é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(AtivoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Ativo é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }
    }
}
 