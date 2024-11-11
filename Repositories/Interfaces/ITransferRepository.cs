using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface ITransferRepository
    {
        Transfer Create(Transfer transfer);
        Transfer Get(string referenceNumber);
        bool Delete(string referenceNumber);
        List<Transfer> GetAll();
    }
}