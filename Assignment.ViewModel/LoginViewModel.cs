using Assignment.BLL;
using Assignment.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string _email;
        private string _password;
        private string _loginMessage;

        public string Email { get => _email; set { _email = value; OnPropertyChanged(); } }
        public string Password { get => _password; set { _password = value; OnPropertyChanged(); } }
        public string LoginMessage { get => _loginMessage; set { _loginMessage = value; OnPropertyChanged(); } }

        public event Action LoginSucceeded;
        public event Action NavigateToRegister;

        public ICommand RegisterCommand => new RelayCommand(() => NavigateToRegister?.Invoke());


        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            var userService = new UserService();
            User user = userService.Login(Email, Password);
            if (user != null)
            {
                LoginSucceeded?.Invoke();
            }
            else
            {
                LoginMessage = "Invalid credentials";
            }
        }
    }
}
