using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Manager
    {
        public string Id = Guid.NewGuid().ToString();
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;
        public string PhoneNumber {get; set;} = default!;
        public string UserEmail {get; set;} = default!;
        public string StaffNumber {get; set;} = default!;
        public bool IsDeleted {get; set;}
    }
}