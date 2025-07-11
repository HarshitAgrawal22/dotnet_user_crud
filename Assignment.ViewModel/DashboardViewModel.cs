using Assignment.BLL;
using Assignment.BO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get => _users;
            set { _users = value; OnPropertyChanged(); }
        }

        public DashboardViewModel()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var userService = new UserService();
            Users = new ObservableCollection<User>(userService.GetAllUsers());
        }
    }
}
