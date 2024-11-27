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

namespace Ex4
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //read number of the screen
            string input = tbx.Text;
            //check if is valid
            int number;
            bool isNum = int.TryParse(input, out number);
            //display the result 
            if (isNum)
            {
                tbk.Text = "Input is a number";
                tbx.Background = Brushes.Green;
            }
            else
            {
                tbk.Text = "Input is not a number";
                tbx.Background = Brushes.Red;
            }
        }

        private void tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx.Clear();
            tbx.Background = Brushes.White;
            tbk.Text = "";
        }
    }
}
