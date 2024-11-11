using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Account Create(Account account);
        Account Get(string accountNumber);
        bool Delete(string accountNumber);
        List<Account> GetAll();
    }
}