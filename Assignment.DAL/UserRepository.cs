using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.BO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Assignment.DAL
{
    public class UserRepository
    {
        private readonly string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=LocalDatabase;Integrated Security=True";

        public User GetUserByEmailAndPassword(string email, string password)
        {
            using SqlConnection conn = new(connectionString);
            conn.Open();
            SqlCommand cmd = new("SELECT * FROM Users WHERE Email = @Email AND Password = @Password", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Gender = reader["Gender"].ToString()
                };
            }

            return null;
        }

        public bool InsertUser(User user)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                SqlCommand cmd = new("INSERT INTO Users (FirstName, LastName, Gender, Email, DateOfBirth, Password) VALUES (@FirstName, @LastName, @Gender, @Email, @DateOfBirth, @Password)", conn);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            } catch (Exception ex) {
                
                throw new Exception(ex.ToString());
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            SqlCommand cmd = new("SELECT * FROM Users", conn);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Gender = reader["Gender"].ToString()
                });
            }

            return users;
        }
    }
}
