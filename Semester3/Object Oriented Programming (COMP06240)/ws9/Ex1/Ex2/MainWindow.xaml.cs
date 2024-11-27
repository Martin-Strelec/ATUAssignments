using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            Member s1 = new Member()
            {
                MemberName = "Jarda",
                Membership = Member.MemberShipTypeE.OAP
            };
            Member s2 = new Member()
            {
                MemberName = "Jarda",
                Membership = Member.MemberShipTypeE.Student
            };
            members.Add(s1);
            members.Add(s2);


            ldxMembers.ItemsSource = members;
            cmx.ItemsSource = Enum.GetValues(typeof(Member.MemberShipTypeE)).Cast<Member.MemberShipTypeE>();
            tbkNoOfMembers.Text = "Number of Members: "+members.Count().ToString();
        }

        private void tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxName.Text = "";
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            members.Add(new Member
            {
                MemberName = string.IsNullOrWhiteSpace(tbxName.Text) ? "No name" : tbxName.Text,
                Membership = cmx.SelectedValue == null ? Member.MemberShipTypeE.None : (Member.MemberShipTypeE)cmx.SelectedValue,
                DateJoined = dtpck.SelectedDate.HasValue ? dtpck.SelectedDate.Value.ToString("dd/MM/yyyy") : "No date"
            });
            tbkNoOfMembers.Text = "Number of Members: " + members.Count().ToString();

            tbxName.Text = "";
        }
    }
}
