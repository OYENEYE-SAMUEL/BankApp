using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.DTOs;
using BankApp.ViewModels;

namespace BankApp.Services.Interfaces
{
    public interface IAccountService
    {
        AccountResponseModel OpenAccount(OpenAccountViewModel model);
    }
}