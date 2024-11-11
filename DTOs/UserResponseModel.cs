using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class UserResponseModel
    {
        public string FullName {get; set;} = default!;
        public string Email {get; set;} = default!;
    }

    public class UserRequestModel
    {
        public string FullName {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
    }
}