using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Ex7
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

        private void tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxInput.Text = "";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            int[] range = {1, 6};
            int input, genNumber;

            genNumber = rng.Next(range[0], range[1] + 1);

            if (int.TryParse(tbxInput.Text, out input)) 
            {
                if (input >= range[0] && input <= range[1])
                {
                    if (input == genNumber)
                    {
                        tbkGuessed.Text = input.ToString();
                        tbkRandom.Text = genNumber.ToString();
                        tbkResult.Text = "You won!";
                    }
                    else
                    {
                        tbkGuessed.Text = input.ToString();
                        tbkRandom.Text = genNumber.ToString();
                        tbkResult.Text = "You lost!";
                    }
                }
                else
                {
                    tbkResult.Background = Brushes.Red;
                    tbkResult.Text = "Invalid range!";
                }
            }
            else
            {
                tbkResult.Background = Brushes.Red;
                tbkResult.Text = "Wrong input!";
            }

            btnRepeat.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnRepeat_Click(object sender, RoutedEventArgs e)
        {
            tbkGuessed.Text = "";
            tbkRandom.Text = "";
            tbkResult.Text = "";
            tbxInput.Text = "";
            btnRepeat.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
