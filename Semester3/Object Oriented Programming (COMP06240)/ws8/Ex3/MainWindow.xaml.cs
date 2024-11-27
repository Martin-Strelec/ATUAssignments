﻿using System;
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

namespace Ex3
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

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            //Update();
            Update2();
        }
        public void Update()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(1, 7);

            tbx.Text = "You rolled: " + randomNumber.ToString();
        }
        public async void Update2()
        {
            int randomNumber;
            Random rng = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomNumber = rng.Next(1, 7);

                tbx.Text = randomNumber.ToString();

                await Task.Delay(50);
            }
        }
    }
}
