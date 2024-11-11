using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class User
    {
        public string Id = Guid.NewGuid().ToString();
        public string FullName {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public string RoleName {get; set;} = default!;
        public bool IsDeleted {get; set;}
    }
}