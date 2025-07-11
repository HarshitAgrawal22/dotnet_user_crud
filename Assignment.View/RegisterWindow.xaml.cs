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
using Assignment.ViewModel;

namespace Assignment.View
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            var vm = new RegisterViewModel();
            this.DataContext = vm;

            PwdBox.PasswordChanged += (s, e) => vm.NewUser.Password = PwdBox.Password;
            ConfirmPwdBox.PasswordChanged += (s, e) => vm.ConfirmPassword = ConfirmPwdBox.Password;
        }
        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Close();
        }
    }
}
