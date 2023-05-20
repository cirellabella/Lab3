using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            cbUsers.ItemsSource = Data.User;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string fName = tbFName.Text;
            string lName = tbLName.Text;
            User nUser = new User(fName, lName);
            Data.AddUser(nUser);
            tbFName.Clear();
            tbLName.Clear();
            Sunglasses sg = new Sunglasses(150, 22, 50, "purple", "Rayban", "Wayfarer", 75);
            nUser.AddSunglasses(sg);
            cbUsers.Items.Refresh();

        }

        private void lbUserInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedUser = cbUsers.SelectedItem.ToString();
            lbUserInfo.Items.Add(selectedUser);

            lbUserInfo.Items.Refresh();
        }
    }
}
