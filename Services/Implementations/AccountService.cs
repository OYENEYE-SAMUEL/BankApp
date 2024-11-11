using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.DTOs;
using BankApp.Repositories.Interfaces;
using BankApp.Services.Interfaces;
using BankApp.ViewModels;

namespace BankApp.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;


        public AccountService(IUserRepository userRepository, ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            _userRepository = userRepository;
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        public AccountResponseModel OpenAccount(OpenAccountViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}