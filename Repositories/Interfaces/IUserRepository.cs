using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        User Get(string email);
        bool Delete(string email);
        List<User> GetAll();
    }
}