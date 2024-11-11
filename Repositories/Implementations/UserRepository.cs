using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Context;
using BankApp.Models;
using BankApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace BankApp.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly BankContext _context;
        public UserRepository(BankContext context)
        {
            _context = context;
        } 

        public User Create(User user)
        {
            var query = "INSERT INTO user (fullname, email, password, rolename) VALUES (@fullname, @email, @password, @rolename)";

            using (var connection = _context.OpenConnection())
            {
                connection.Open();
                var command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@fullname", user.FullName);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@rolename", user.RoleName);

                int response = command.ExecuteNonQuery();

                if(response > 0)
                {
                    return user;
                }
                    
                return null;
            }
        }

        public bool Delete(string email)
        {
            throw new NotImplementedException();
        }

        public User Get(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}