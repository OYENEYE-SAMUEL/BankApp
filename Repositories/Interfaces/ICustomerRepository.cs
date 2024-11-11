using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        Customer Get(string bvn);
        bool Delete(string bvn);
        List<Customer> GetAll();
    }
}