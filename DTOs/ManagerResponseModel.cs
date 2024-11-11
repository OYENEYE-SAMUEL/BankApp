using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class ManagerResponseModel
    {
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;
        public string PhoneNumber {get; set;} = default!;
        public string UserEmail {get; set;} = default!;
        public string StaffNumber {get; set;} = default!;
    }

    public class ManagerRequestModel
    {
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;
        public string PhoneNumber {get; set;} = default!;
    }
}