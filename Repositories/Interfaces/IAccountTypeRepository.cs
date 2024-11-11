using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface IAccountTypeRepository
    {
        AccountType Create(AccountType accountType);
        AccountType Get(string name);
        bool Delete(string name);
        List<AccountType> GetAll();
    }
}