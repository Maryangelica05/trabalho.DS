using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace trabalho.DS
{
    public partial class Financeiro : ContentPage
    {
        private ObservableCollection<Expense> Expenses { get; set; }

        public Financeiro()
        {
            InitializeComponent();
            Expenses = new ObservableCollection<Expense>
            {
                new Expense { Date = "07-08-24", Description = "Malha Azul", Value = 85.00 },
                new Expense { Date = "08-08-2024", Description = "Malha Vermelha", Value = 60.00 }
            };
            ExpensesCollectionView.ItemsSource = Expenses;
            UpdateTotalExpenses();
        }

        private async void OnAddNewExpenseClicked(object sender, EventArgs e)
        {
            var addExpensePage = new AddExpensePage();
            addExpensePage.ExpenseAdded += (s, expense) =>
            {
                Expenses.Add(expense);
                UpdateTotalExpenses();
            };
            await Navigation.PushAsync(addExpensePage);
        }

        private void UpdateTotalExpenses()
        {
            var total = 0.0;
            foreach (var expense in Expenses)
            {
                total += expense.Value; // Usar 'Value' para corresponder ao nome da propriedade
            }
            TotalExpensesLabel.Text = $"Gastos Totais: R$ {total:F2}";
        }
    }

    public class Expense
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public double Value { get; set; } // Usar 'Value' para corresponder ao nome da propriedade
    }
     private void OnproximoClicked(object sender, EventArgs e)
        {
            // Lógica para o botão continuar
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
           Application.Current.MainPage = new Login();
        }

}
