using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.DTOs;
using BankApp.Repositories.Interfaces;

namespace BankApp.ViewModels
{
    public class OpenAccountViewModel
    {
        public UserRequestModel User{ get; set; }
        public CustomerRequestModel Customer{ get; set; }
        public AccountRequestModel Account{ get; set; }
    }
}