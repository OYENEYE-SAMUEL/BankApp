using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;
using BankApp.Repositories.Interfaces;

namespace BankApp.Repositories.Implementations
{
    public class ManagerRepository : IManagerRepository
    {
        public Manager Create(Manager manager)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string staffNumber)
        {
            throw new NotImplementedException();
        }

        public Manager Get(string staffNumber)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}