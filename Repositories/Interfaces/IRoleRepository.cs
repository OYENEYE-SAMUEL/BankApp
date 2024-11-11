using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Role Create(Role role);
        Role Get(string name);
        bool Delete(string name);
        List<Role> GetAll();
    }
}