using Microsoft.Maui.Controls;
using System;

namespace trabalho.DS
{
    public partial class AddExpensePage : ContentPage
    {
        public event EventHandler<Expense> ExpenseAdded;

        public AddExpensePage()
        {
            InitializeComponent();
        }

        private async void OnSaveExpenseClicked(object sender, EventArgs e)
        {
            var expense = new Expense
            {
                Date = DateEntry.Text,
                Description = DescriptionEntry.Text,
                Value = double.TryParse(ValueEntry.Text, out var value) ? value : 0
            };

            ExpenseAdded?.Invoke(this, expense);
            await Navigation.PopAsync();
        }
    }
}
