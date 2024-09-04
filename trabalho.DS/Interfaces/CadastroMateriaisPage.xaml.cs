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

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaMateriaisPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (materiais != null)
            {
                IdLabel.Text = materiais.Id.ToString();
                NomematerialEntry.Text = materiais.Nome;
                NomeFornecedorEntry.Text = materiais.NomeFornecedor;
                AtivoEntry.Text = materiais.Ativo;
      
            }

             }

        //--------------------------------------------------------------------------------------------------
        // Método para apagar os dados do material
        private async void OnApagarMaterialClicked(object sender, EventArgs e)
        {
            // Verifica se estamos editando um material ou criando um material
            // Se estiver criando, não se pode apagar, já que não se tem um `material.Id`
            if (material == null || material.Id < 1)
                await DisplayAlert("Erro", "Nenhum material para excluir", "OK");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse material?", "Excluir Material", "Cancelar")) // Caso o usuário toque no Botão "Excluir Material"
            {
                // Apaga do Banco de Dados
                materialControle.Apagar(material.Id);
                // Volta para a tela de Lista
                Application.Current.MainPage = new ListaMateriaisPage();
            }
        }

        //--------------------------------------------------------------------------------------------------

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
            {
                // O código abaixo preenche o objeto material (Modelo) com os dados das Entry's
                var material = new Modelos.Material();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    material.Id = int.Parse(IdLabel.Text);
                else
                    material.Id = 0;
                material.Nome = NomeMaterialEntry.Text;
                material.NomeFornecedor = NomeFornecedorEntry.Text;
                material.Ativo = AtivoEntry.Text;

                // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
                materiaisControle.CriarOuAtualizar(materiais);
                // Mostra a mensagem de sucesso
                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
                // Opcional: Redireciona para a lista de materiais após salvar
                Application.Current.MainPage = new ListaMateriaisPage();
            }
        }

        //--------------------------------------------------------------------------------------------------
        // Esse método pode ser escrito de várias maneiras. A ideia é que você valide os dados antes de 
        // preencher o objeto (Modelo). 
        // Perceba que além da retornar false (para indicar erro), também mostra qual o erro
        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            // Verifica se a Entry do Nome está vazia
            if (String.IsNullOrEmpty(NomeMaterialEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Fornecedor está vazia
            else if (String.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome do Fornecedor é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Ativo está vazia
            else if (String.IsNullOrEmpty(AtivoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Ativo é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }

        //--------------------------------------------------------------------------------------------------
    }
}
        