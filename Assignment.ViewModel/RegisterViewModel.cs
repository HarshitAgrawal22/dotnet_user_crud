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
    public class RegisterViewModel : BaseViewModel
    {
        private User _newUser = new();
        private string _confirmPassword;
        private string _registerMessage;

        public User NewUser { get => _newUser; set { _newUser = value; OnPropertyChanged(); } }
        public string ConfirmPassword { get => _confirmPassword; set { _confirmPassword = value; OnPropertyChanged(); } }
        public string RegisterMessage { get => _registerMessage; set { _registerMessage = value; OnPropertyChanged(); } }

        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            NewUser = new User
            { Gender = "Please Select",
                DateOfBirth = new DateTime(1980, 1, 1)
            };
            RegisterCommand = new RelayCommand(Register);
        }


        private void Register()
        {
            if (string.IsNullOrWhiteSpace(NewUser.FirstName) ||
                string.IsNullOrWhiteSpace(NewUser.Email) ||
                NewUser.Password != ConfirmPassword)
            {
                RegisterMessage = "Invalid data or passwords don't match.";
                return;
            }

            var userService = new UserService();
            bool result = userService.Register(NewUser);
            RegisterMessage = result ? "Registered successfully" : "Registration failed.";
        }
    }
}
