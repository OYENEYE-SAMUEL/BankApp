using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;
using BankApp.Repositories.Interfaces;

namespace BankApp.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        public Account Create(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Account Get(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}