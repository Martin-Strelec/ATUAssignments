using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expense> Expenses = new ObservableCollection<Expense>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Expenses.Add(new Expense());
            Expenses.Add(new Expense());
            Expenses.Add(new Expense());

            ldxExpenseView.ItemsSource = Expenses;
            tbkTotal.Text = $"Total Cost: {Expenses.Sum(Expense => Expense.Cost):c}";
        }

        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            Expenses.Add(new Expense());
            tbkTotal.Text = $"Total Cost: {Expenses.Sum(Expense => Expense.Cost):c}";
        }
    }
}
