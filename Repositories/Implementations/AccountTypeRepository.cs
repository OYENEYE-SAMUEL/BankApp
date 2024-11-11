using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;
using BankApp.Repositories.Interfaces;

namespace BankApp.Repositories.Implementations
{
    public class AccountTypeRepository : IAccountTypeRepository
    {
        public AccountType Create(AccountType accountType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string name)
        {
            throw new NotImplementedException();
        }

        public AccountType Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<AccountType> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}