
namespace trabalho.DS
{
    public partial class Gerenciamentofornecedor : ContentPage
    {
        public Gerenciamentofornecedor()
        {
            InitializeComponent();
        }

        private void OnDesativarClicked(object sender, EventArgs e)
        {
            // Show the confirmation area
            confirmationArea.IsVisible = true;
        }

        private void OnEditarClicked(object sender, EventArgs e)
        {
            // Navigate to the edit page or handle edit functionality
            // Navigation logic here, for example:
            // await Navigation.PushAsync(new EditFornecedorPage());
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Hide the confirmation area
            confirmationArea.IsVisible = false;
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            // Handle the deactivation logic here
            // For example, removing the supplier from a list or marking as inactive
            // Hide the confirmation area
            confirmationArea.IsVisible = false;
            
            // Display a confirmation message
            DisplayAlert("Confirmado", "Fornecedor desativado", "OK");
        }
    }
}
