using Assignment.BLL;
using Assignment.BO;
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
using System.Windows.Shapes;

namespace Assignment.View
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Close();
        }

        private void LoadUsers()
        {
            UserService userService = new();
            List<User> users = userService.GetAllUsers();
            UserListView.ItemsSource = users;
        }
    }
}
