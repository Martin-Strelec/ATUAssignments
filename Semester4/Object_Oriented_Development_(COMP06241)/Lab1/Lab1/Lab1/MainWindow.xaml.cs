using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> bands = new List<Band>();
        string[] genres = { "RockBand", "PopBand", "IndieBand" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Adding bands to the list
            bands.Add(new RockBand("Cypress Hill", "01/01/2008",
                                    new string[] { "Sen Dog", "B-Real", "Dj Muggs", "Eric Bobo", "Mix Master Mike", "Mellow Man Ace" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));
            bands.Add(new RockBand("Slipknot", "01/01/1995",
                                    new string[] { "Corey Taylor", "Joey Jordison", "Shawn Crahan", "Mick Thomson", "Sid Wilson", "Eloy Casagrande", "Chris Fehn", "Paul Gray", "Jim Root", "Jay Weinberg", "Craig Jones", "Michael Pfaff", "Alessandro Venturella" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));
            bands.Add(new RockBand("System Of a Down", "01/01/1994",
                                    new string[] { "Serj Tankian", "Daron Malakian", "Shavo Odadijan", "John Dolmayan", "Ontronik" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));
            bands.Add(new RockBand("Deftones", "01/01/1988",
                                    new string[] { "Chino Moreno", "Chi Cheng", "Stephen Carpenter", "Abe Cunningham", "Frank Delgado", "Dominic Garcia", "Freb Sablan", "Shaun Lopez", "Sergio Vega", "John Taylor" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));
            bands.Add(new IndieBand("Gorillaz", "01/01/1998",
                                    new string[] { "Damon Albarn", "Jamie Hewlett" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));
            bands.Add(new RockBand("Audioslave", "01/01/2001",
                                    new string[] { "Chris Cornell", "Tom Morello", "Tim Commerford", "Brad Wilk" },
                                    new List<Album> {
                                        new Album("G-Sides","01/01/2001",600),
                                        new Album("Laika Come Home", "01/01/2002", 980),
                                        new Album("D-Sides", "01/01/2007", 8754) }));


            bands.Sort(); //Sorting bands by their name

            //Setting default values when windows loads
            if (bands.Count > 0)
            {
                lbxBandName.SelectedItem = bands[0] as Band; //First element of the list as default 
                lbxBandName.ItemsSource = bands;
                SearchBox.ItemsSource = genres;

                tbkFormed.Text = (lbxBandName.SelectedItem as Band).YearFormed.Year.ToString(); 
                lbxAlbums.ItemsSource = (lbxBandName.SelectedItem as Band).Albums;
                lbxMembers.ItemsSource = (lbxBandName.SelectedItem as Band).Members;
            }
        }

        private void lbxBandName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bands.Count > 0 && lbxBandName.ItemsSource != null)
            {
                lbxAlbums.ItemsSource = null;
                tbkFormed.Text = "";

                tbkFormed.Text = (lbxBandName.SelectedItem as Band).YearFormed.Year.ToString();
                lbxAlbums.ItemsSource = (lbxBandName.SelectedItem as Band).Albums;
                lbxMembers.ItemsSource = (lbxBandName.SelectedItem as Band).Members;
            }
        }

        private void SearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Band> tempList = new List<Band>(); //Creating temporary list

            if (bands.Count > 0)
            {
                lbxBandName.ItemsSource = null;
                foreach (Band band in bands) //Checking each band if band genre matches the genre of the search
                {
                    if ((string)SearchBox.SelectedValue == band.GetType().Name)
                    {
                        tempList.Add(band);
                    }
                }
                lbxBandName.ItemsSource = tempList;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Band selectedBand = lbxBandName.SelectedItem as Band; //Retrieving selected band

            if (tbxDescription.Text != "" && selectedBand != null)
            {
                using (StreamWriter sw = new StreamWriter($"../../{selectedBand.Name}-Description.txt")) 
                {
                    sw.WriteLine(tbxDescription.Text);
                }
                tbxDescription.Text = "";

                //Success message
                tbkAnnoucment.Text = "Description Saved!";
                tbkAnnoucment.Foreground = new SolidColorBrush(Colors.Green);

            }
            else
            {
                //Error Message
                tbkAnnoucment.Text = "Saving Failed!";
                tbkAnnoucment.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}

