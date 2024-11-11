using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class AccountResponseModel
    {
        public string Name {get; set;} = default!;
        public string AccountNumber {get; set;} = default!;
        public string AccountTypeName {get;set;} = default!;
        public bool IsActive {get; set;} = true;
    }

    public class AccountRequestModel
    {
        public string Name {get; set;} = default!;
        public string AccountTypeName {get;set;} = default!;
    }
}