using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Ex5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int initialNumber;
        Random rng = new Random();

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            tbkSecondNumber.Text = "";
            tbkResult.Text = "";
            btnStartGame.Content = "Start Game";

            tbkFirstNumber.Visibility = System.Windows.Visibility.Visible;
            radBigger.Visibility = System.Windows.Visibility.Visible;
            radSmaller.Visibility = System.Windows.Visibility.Visible;
            btnGuess.Visibility = System.Windows.Visibility.Visible;
            tbkSecondNumber.Visibility = System.Windows.Visibility.Visible;
            tbkResult.Visibility = System.Windows.Visibility.Visible;

            initialNumber = rng.Next(0, 21);

            tbkFirstNumber.Text = "Initial number: " + initialNumber.ToString();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            bool isInRange;
            int number = rng.Next(0, 21);

            btnStartGame.Content = "Restart Game";
            tbkSecondNumber.Text = number.ToString();

            if (radBigger.IsChecked == true)
            {
                if (number > initialNumber)
                {
                    tbkResult.Text = "You won!";
                }
                else
                {
                    tbkResult.Text = "You Lost";
                }
            }
            else if (radSmaller.IsChecked == true)
            {
                if (number < initialNumber)
                {
                    tbkResult.Text = "You won!";
                }
                else
                {
                    tbkResult.Text = "You Lost";
                }
            }
        }
    }
}
