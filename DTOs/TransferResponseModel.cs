using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class TransferResponseModel
    {
        public string ReferenceNumber {get; set;} = default!;
        public string SenderAccountNumber {get; set;} = default!;
        public string ReceiverAccountNumber {get; set;} = default!;
        public bool IsSuccessful {get; set;}
    }

    public class TransferRequestModel
    {
        public string SenderAccountNumber {get; set;} = default!;
        public string ReceiverAccountNumber {get; set;} = default!;
    }
}