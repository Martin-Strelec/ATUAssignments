using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //Observable Collection library
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

namespace LectureEx1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] names = { "Lou", "Jack", "Dick" };

            Student s1 = new Student()
            {
                FirstName = names[0],
                LastName = "McMc",
                Year = 3
            };
            Student s2 = new Student()
            {
                FirstName = names[1],
                LastName = "McMcMc",
                Year = 2
            };
            Student s3 = new Student()
            {
                FirstName = names[2],
                LastName = "McMcMCMC",
                Year = 1
            };

            //List would work aswell. This has the feature of automatic update of content
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            ldxStudents.ItemsSource = students;
        }

        private void tbxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxFirstName.Text = "";
        }

        private void tbxLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxLastName.Text = "";
        }

        private void tbxCourse_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxYear.Text = "";
        }

        private void ldxStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Determine what was selected in lbx
            Student selectedStudent = ldxStudents.SelectedItem as Student;
            if (selectedStudent != null)
            {
                //Updated display with those details
                tbxYear.Text = $"{selectedStudent.Year}";
            }

        }
    }
}
