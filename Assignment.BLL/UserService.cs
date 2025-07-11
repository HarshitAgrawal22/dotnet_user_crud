using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment.BO;
using Assignment.DAL;

namespace Assignment.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepo;

        public UserService()
        {
            _userRepo = new UserRepository();
        }

        public User Login(string email, string password)
        {
            return _userRepo.GetUserByEmailAndPassword(email, password);
        }

        public bool Register(User user)
        {
            return _userRepo.InsertUser(user);
        }


        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }
    }
}
