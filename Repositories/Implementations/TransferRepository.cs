using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;
using BankApp.Repositories.Interfaces;

namespace BankApp.Repositories.Implementations
{
    public class TransferRepository : ITransferRepository
    {
        public Transfer Create(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string referenceNumber)
        {
            throw new NotImplementedException();
        }

        public Transfer Get(string referenceNumber)
        {
            throw new NotImplementedException();
        }

        public List<Transfer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}