using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.DS
{
    public partial class GerenciamentomateriaisPage : ContentPage
    {
        public Materiais materiais { get; set; }
        Controles.MateriaisControle materiaisControle = new Controles.MateriaisControle();

        public GerenciamentomateriaisPage()
        {
            InitializeComponent();
            ListaMateriais.ItemsSource = materiaisControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroMaterialPage,
            // que é a página onde os dados do material podem ser criados/editados
            var page = new CadastroMateriaisPage();
            // O passo seguinte é dizer para nova página qual material foi selecionado. Olhe o código da CadastroMaterialPage,
            // e verifique que lá terá um atributo público do tipo Material, chamado material.
            // Toda vez que se clica em um material na lista nessa página, setaremos na CadastroMaterialPage o atributo material 
            // com o material que foi clicado aqui.
            page.materiais = e.SelectedItem as Materiais;
            // Troca-se a página principal para a página que acabamos de criar
            Application.Current.MainPage = page;
        }

        void NovoMaterialClicked(object sender, EventArgs e)
        {
            // Quando a ideia é CRIAR um novo material, não é necessário setar o atributo "material" na CadastroMaterialPage,
            // sendo assim, apenas criamos a nova página
            Application.Current.MainPage = new CadastroMateriaisPage();
        }
    }
}
