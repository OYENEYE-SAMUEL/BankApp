using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models.Enums;

namespace BankApp.DTOs
{
    public class CustomerResponseModel
    {
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;
        public string PhoneNumber {get; set;} = default!;
        public DateTime Dob {get; set;} = default!;
        public Gender Gender{get; set;} = default!;
        public string UserEmail {get; set;} = default!;
        public string Address {get; set;} = default!;
        public string AccountName {get; set;} = default!; 
    }

    public class CustomerRequestModel
    {
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;
        public string PhoneNumber {get; set;} = default!;
        public DateTime Dob {get; set;} = default!;
        public Gender Gender{get; set;} = default!;
        public string Address {get; set;} = default!;
        public string UtilityBill {get; set;} = default!;
        public string NIN {get; set;} = default!;
        public string BVN {get; set;} = default!;
    }
}