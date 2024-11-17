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

namespace Ex6
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
            tbx.Text = "";
            tbk.Text = "";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int input;

            if (int.TryParse(tbx.Text, out input))
            {
                if ((input % 2) == 0)
                {
                    tbk.Text = "Number is even!";
                    tbk.Background = Brushes.LightBlue;
                }
                else
                {
                    tbk.Text = "Number is odd!";
                    tbk.Background = Brushes.Yellow;
                }
            }
            else
            {
                tbk.Text = "Wrong Input!";
                tbk.Background = Brushes.Red;
            }
        }
    }
}
