using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Account
    {
        public string Id = Guid.NewGuid().ToString();
        public string Name {get; set;} = default!;
        public string AccountNumber {get; set;} = default!;
        public string AccountTypeName {get;set;} = default!;
        public bool IsActive {get; set;} = true;
        public bool IsDeleted {get; set;}
    }
}