using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Transfer
    {
        public string Id = Guid.NewGuid().ToString();
        public string ReferenceNumber {get; set;} = default!;
        public string SenderAccountNumber {get; set;} = default!;
        public string ReceiverAccountNumber {get; set;} = default!;
        public bool IsSuccessful {get; set;}
        public bool IsDeleted {get; set;}
    }
}