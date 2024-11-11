using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;
using BankApp.Repositories.Interfaces;

namespace BankApp.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string bvn)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string bvn)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}