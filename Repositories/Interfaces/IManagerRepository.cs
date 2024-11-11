using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface IManagerRepository
    {
        Manager Create(Manager manager);
        Manager Get(string staffNumber);
        bool Delete(string staffNumber);
        List<Manager> GetAll();
    }
}